using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerManagerPiratia
{
    public partial class NpcManagerForm : Form
    {
        // NPC data structure
        private class Npc
        {
            // Constructor
            public Npc()
            {
                Id       = 0;
                Name     = "New NPC";
                Type_id  = 1;
                Icon_id  = 0;
                Model_id = 1;
                Pos_x    = Pos_y = 0;
                Angle    = 180;
                Location = "Enter NPC location, e.g. Argent City . . .";
                Unknown0 = 1;
                Unknown1 = 0;
                Script   = "Enter function name from NpcScriptXX.lua . . .";
                Unknown2 = "0";
                Changed = true;
            }

            // Convert NPC line from *npc.txt file into the structure
            public void FromNpcLine(string str)
            {
                // Convert (x, y) string to integer values
                var xy_from_str = (string str, ref int x, ref int y) =>
                {
                    // Remove spaces from the given string
                    str = string.Concat(str.Where(c => !char.IsWhiteSpace(c)).ToArray());

                    // Search ; character
                    if ( str.Where(x => (x == ',')).Any() == false )
                    {
                        // Error
                        throw new Exception("Wrong NPC position format: separator (,) missing!");
                    }

                    // Split string by ;
                    string[] xy = str.Split(',');

                    // Check the number of substrings
                    if (xy.Length != 2)
                    {
                        // Error
                        throw new Exception(string.Format("Wrong NPC position format: {0} substrings instead of 2!", xy.Length));
                    }

                    // Convert string to int
                    try
                    {
                        x = int.Parse(xy[0]);
                        y = int.Parse(xy[1]);
                    }
                    catch (Exception ex)
                    {
                        // Conversion error
                        x = 0;
                        y = 0;

                        // Throw exception
                        throw new Exception(string.Format("Wrong NPC position format: can't convert string to number ({0})!", ex.Message));
                    }
                };

                // Split the NPC line by tabulator
                string[] npc = str.Split('\t');

                // Check the number of substrings
                if (npc.Length != 13)
                {
                    // Error
                    throw new Exception(string.Format("Wrong NPC line format: {0} substrings instead of 13!", npc.Length));
                }

                // Parse the NPC line
                try
                {
                    Id       = int.Parse(npc[0]);
                    Name     =           npc[1];
                    Type_id  = int.Parse(npc[2]);
                    Model_id = int.Parse(npc[3]);
                    Icon_id  = int.Parse(npc[4]);

                    int tmp_x = 0;
                    int tmp_y = 0;
                    xy_from_str(npc[5], ref tmp_x, ref tmp_y);

                    Pos_x = tmp_x;
                    Pos_y = tmp_y;

                    Angle    = int.Parse(npc[7]);
                    Location =           npc[8];
                    Unknown0 = int.Parse(npc[9]);
                    Unknown1 = int.Parse(npc[10]);
                    Script   =           npc[11];
                    Unknown2 =           npc[12];

                    Changed = false;
                }
                catch
                {
                    throw;
                }
            }

            // Convert the structure into NPC line for *npc.txt file
            public string ToNpcLine()
            {
                // Build the line
                return new string(
                    string.Format(
                        "{0}\t{1}\t{2}\t{3}\t{4}\t{5},{6}\t{7},{8}\t{9}\t{10}\t{11}\t{12}\t{13}\t{14}",
                        Id,
                        Name,
                        Type_id,
                        Model_id,
                        Icon_id,
                        Pos_x, Pos_y,
                        Pos_x, Pos_y,
                        Angle,
                        Location,
                        Unknown0,
                        Unknown1,
                        Script,
                        Unknown2
                    )
                );
            }

            // Convert the structure to string
            public override string ToString()
            {
                return string.Format("[ID: {0}] {1}", Id, Name);
            }

            public int Id { get; set; }
            public string Name { get; set; }
            public int Type_id { get; set; }
            public int Model_id { get; set; }
            public int Icon_id { get; set; }
            public int Pos_x { get; set; }
            public int Pos_y { get; set; }
            public int Angle { get; set; }
            public string Location { get; set; }
            public int Unknown0 { get; set; }   
            public int Unknown1 { get; set; }    
            public string Script { get; set; }
            public string Unknown2 { get; set; }
            public bool Changed { get; set; }
        }

        // NPC Manager form constructor
        public NpcManagerForm()
        {
            InitializeComponent();

            // Make pen
            pen = new(Color.White, 2);

            // Fill label map
            Labels = new();
            Labels.Add(0, labelNpcID);
            Labels.Add(1, labelNpcName);
            Labels.Add(2, labelNpcModel);
            Labels.Add(3, labelNpcIcon);
            Labels.Add(4, labelNpcPosX);
            Labels.Add(5, labelNpcPosY);
            Labels.Add(6, labelNpcAngle);
            Labels.Add(7, labelNpcLocation);
            Labels.Add(8, labelNpcScript);
        }

        // Form show event
        private void NpcManagerForm_Shown(object sender, EventArgs e)
        {
            // Clear NPC list
            listBoxNpc.Items.Clear();

            // Clear text boxes
            {
                // Our text boxes array
                TextBox[] textBoxes = { textBoxPath, textBoxNpcID, textBoxNpcName, textBoxNpcModel,
                    textBoxNpcPosX, textBoxNpcPosY, textBoxNpcLocation, textBoxNpcScript };

                // Clear them!
                foreach (TextBox box in textBoxes)
                {
                    box.Clear();
                }
            }

            // Reset minimap icon
            comboBoxNpcIcon.SelectedIndex = 0;

            // Reset angle
            textNpcAngle.Value = 0;

            // Create new NPC
            listBoxNpc.Items.Add(new Npc());

            // Select new NPC
            listBoxNpc.SelectedIndex = (listBoxNpc.Items.Count - 1);

            // Update NPC list group box name
            groupBoxLeft.Text = string.Format("NPC list ({0})", listBoxNpc.Items.Count);
        }

        // Form close event
        private void NpcManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Ask user should the NPC list be saved?
            AskUser();
        }

        // Load NPCs from *npc.txt file
        private void LoadNpcFromTextFile(string path)
        {
            // Line counter
            uint counter = 0;

            // Reset maximum NPC ID
            Max_id = 0;

            try
            {
                // Read lines from the file to array of strings
                string[] lines = System.IO.File.ReadAllLines(path);

                // Iterate over the array
                foreach (string line in lines)
                {
                    // Count the line
                    ++counter;

                    // Trim the line
                    string tmp = line.Trim();

                    // Check that line is not empty
                    if (tmp.Length == 0)
                    {
                        // Skip the line
                        continue;
                    }

                    // Check that line is not commented
                    if (tmp.IndexOf("//") == 0)
                    {
                        // Skip the line
                        continue;
                    }
                    
                    // Create new NPC object
                    Npc npc = new();

                    // Parse the current line
                    npc.FromNpcLine(line);

                    // Add NPC to the list
                    listBoxNpc.Items.Add(npc);

                    // Calculate maximum NPC ID
                    if (Max_id < npc.Id)
                    {
                        // Save new maximum ID
                        Max_id = npc.Id;
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        // Save NPCs into *npc.txt file
        private void SaveNpcFromTextFile(string path)
        {
            try
            {
                // Open the output file
                using StreamWriter file = new(path);

                // Write NPcs
                foreach (Npc npc in listBoxNpc.Items)
                {
                    file.WriteLine(npc.ToNpcLine());
                }
            }
            catch
            {
                throw;
            }
        }

        // Path button click event
        private void ButtonPath_Click(object sender, EventArgs e)
        { 
            // Show to user the open file dialog
            if (openFileDialog.ShowDialog() == DialogResult.OK) 
            {
                // Save path to the selected file
                textBoxPath.Text = openFileDialog.FileName;

                // Clear the old NPCs list
                listBoxNpc.Items.Clear();

                // Trying open the file
                try
                {
                    LoadNpcFromTextFile(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Can't load NPC list! {0}", ex.Message), "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Update NPC number
                groupBoxLeft.Text = string.Format("NPC list ({0})", listBoxNpc.Items.Count);

                // Select 1st item
                listBoxNpc.SelectedIndex = (listBoxNpc.Items.Count > 0) ? 0 : -1;

                // Check NPCs number
                if (listBoxNpc.Items.Count > 0)
                {
                    // Show the main panel
                    panelMain.Show();
                }
                else
                {
                    // Hide the main panel
                    panelMain.Hide();
                }
            }
        }

        // Save button click event
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            // Path to the output file
            string path;

            // Check that file has been loaded from a file
            if (textBoxPath.Text.Length != 0)
            {
                // Use old path
                path = textBoxPath.Text;
            }
            else
            {
                // Show save file dialog
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Use new path
                    path = saveFileDialog.FileName;
                }
                else
                {
                    // Cancel saving
                    return;
                }
            }

            try
            {
                // Save NPC list
                SaveNpcFromTextFile(path);

                // Save current path to *npc.txt file
                openFileDialog.FileName = path;
                textBoxPath.Text = openFileDialog.FileName;

                // Reset changed state on all NPCs
                foreach (Npc npc in listBoxNpc.Items)
                {
                    npc.Changed = false;
                }

                // Refresh NPC list
                listBoxNpc.Refresh();

                // Show a message to user
                MessageBox.Show(string.Format("NPC list has been successfully saved to {0} file!", 
                    Path.GetFileName(path)), "NPCs saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Can't save NPC list! {0}", ex.Message),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // New *npc.txt file
        private void ButtonMakeNpcFile_Click(object sender, EventArgs e)
        {
            // Ask user should the NPC list be saved?
            AskUser();

            // Reset path to the old file
            textBoxPath.Clear();

            // Remove the old list
            listBoxNpc.Items.Clear();

            // Create new NPC
            listBoxNpc.Items.Add(new Npc());

            // Select new NPC
            listBoxNpc.SelectedIndex = (listBoxNpc.Items.Count - 1);

            // Update NPC list group box name
            groupBoxLeft.Text = string.Format("NPC list ({0})", listBoxNpc.Items.Count);

            // Reset NPC id counter
            Max_id = 0;
        }

        // Add NPC button click
        private void ButtonNpcAdd_Click(object sender, EventArgs e)
        {
            // Create a new NPC
            Npc npc = new();
            npc.Id = ++Max_id;
            npc.Changed = true;

            // Add NPC to the list
            listBoxNpc.Items.Add(npc);

            // Update NPC counter
            groupBoxLeft.Text = string.Format("NPC list ({0})", listBoxNpc.Items.Count);

            // Select the new NPC
            listBoxNpc.SelectedIndex = listBoxNpc.Items.Count - 1;

            // Show the main panel
            panelMain.Show();
        }

        // Remove NPC button click
        private void ButtonNpcRemove_Click(object sender, EventArgs e)
        {
            // Check that user selected a NPC
            if (listBoxNpc.SelectedIndex != -1)
            {
                // Get selected NPC
                Npc npc = (Npc)listBoxNpc.SelectedItem;

                // Ask user
                DialogResult r = MessageBox.Show(string.Format("Are you sure you want to delete the NPC \"{0}\"?", npc.ToString()),
                    "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                // Check result
                if (r == DialogResult.OK)
                {
                    // Current index
                    int index = listBoxNpc.SelectedIndex;

                    // Remove the NPC from the list
                    listBoxNpc.Items.RemoveAt(index);

                    // Update NPC counter
                    groupBoxLeft.Text = string.Format("NPC list ({0})", listBoxNpc.Items.Count);

                    // Check the NPC number in the list left
                    if (listBoxNpc.Items.Count > 0)
                    {
                        // Select the previous NPC
                        listBoxNpc.SelectedIndex = (index > 0) ? (index - 1) : 0;
                    }
                    else
                    {
                        // Hide the main panel
                        panelMain.Hide();
                    }
                }
            }
        }

        // NPC selection event
        private void ListBoxNpc_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check selected item index
            if (listBoxNpc.SelectedIndex == -1)
            {
                // No NPC selected?!
                return;
            }
            
            // Get current NPC
            Npc npc = (Npc)listBoxNpc.Items[listBoxNpc.SelectedIndex];

            // Start update the form
            BeginUpdate();

            try
            {
                // Update group box title
                groupBoxMain.Text = string.Format("NPC: {0}", npc.Name);

                // Update NPC fields
                textBoxNpcID.Text = npc.Id.ToString();
                textBoxNpcName.Text = npc.Name;
                textBoxNpcModel.Text = npc.Model_id.ToString();
                textBoxNpcPosX.Text = (npc.Pos_x / 100).ToString();
                textBoxNpcPosY.Text = (npc.Pos_y / 100).ToString();
                textNpcAngle.Value = npc.Angle % 360;
                textBoxNpcLocation.Text = npc.Location;
                textBoxNpcScript.Text = npc.Script;
                comboBoxNpcIcon.SelectedIndex = (int)npc.Icon_id;

                // Reset labels colors
                foreach (KeyValuePair<int, Label> pair in Labels)
                {
                    pair.Value.ForeColor = Color.White;
                }
            }
            finally
            {
                // Stop update the form
                EndUpdate();
            }
        }

        // Draw NPC element in the list
        private void ListBoxNpc_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Check selected item index
            if (e.Index == -1)
            {
                // No NPC selected?!
                return;
            }

            // Get current NPC
            Npc npc = (Npc)listBoxNpc.Items[e.Index];

            // Draw background of the element
            e.DrawBackground();

            // Check that we have icons in the image list
            if (imageList.Images.Count > 0)
            {
                // Draw NPC minimap icon
                imageList.Draw(
                    e.Graphics,
                    e.Bounds.X + 2, e.Bounds.Y + 2,
                    (npc.Icon_id < imageList.Images.Count) ? npc.Icon_id : (imageList.Images.Count - 1)
                );
            }
            
            // Draw NPC name
            if (e.Font != null)
            {
                e.Graphics.DrawString(
                    (npc.Changed == true) ? npc.ToString().Insert(0, "* ") : npc.ToString(),
                    e.Font,
                    (npc.Changed == true) ? Brushes.Red : Brushes.Black,
                    e.Bounds.X + 20,
                    e.Bounds.Y + 2
                );
            }
        }

        // Draw NPC minimap icons in the appropriate ComboBox list
        private void ComboBoxNpcIcon_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Check the ComboBox index
            if (e.Index == -1)
            {
                // Noting to draw . . .
                return;
            }

            // Calculate an icon position
            int x = e.Bounds.X + (comboBoxNpcIcon.Width - imageList.ImageSize.Width - 12) / 2;
            int y = e.Bounds.Y + 2;

            // Draw background of the element
            e.DrawBackground();

            // Check that we have icons in the image list
            if (imageList.Images.Count > 0)
            {
                // Draw NPC minimap icon
                imageList.Draw(
                    e.Graphics,
                    x, y,
                    (e.Index < imageList.Images.Count) ? e.Index : (imageList.Images.Count - 1)
                );
            }
        }

        // Draw picture with NPC angle
        private void PictureBoxNpcAngle_Paint(object sender, PaintEventArgs e)
        {
            // Angle 
            int angle = 0;

            // Check the ListBox index
            if (listBoxNpc.SelectedIndex != -1)
            {
                // Get current NPC angle
                angle = ((Npc)listBoxNpc.SelectedItem).Angle;
            }

            // Calculate coordinates for angle direction line
            int x0 = pictureBoxNpcAngle.Width / 2;
            int y0 = pictureBoxNpcAngle.Height / 2;
            int x1 = x0 + (int)(x0 * Math.Cos(((angle - 90) * Math.PI / 180)));
            int y1 = y0 + (int)(y0 * Math.Sin(((angle - 90) * Math.PI / 180)));

            // Draw angle direction
            e.Graphics.DrawLine(pen, x0, y0, x1, y1 );

            // Draw circle
            e.Graphics.DrawEllipse(pen, 0, 0, pictureBoxNpcAngle.Width - 1, pictureBoxNpcAngle.Height - 1);
        }

        // NPC field change by user event
        private void FieldNpc_Changed(object sender, EventArgs e)
        {
            // Check that forms is being updated programmaticaly
            if (Updating == true)
            {
                // Forms is being updated programmaticaly
                return;
            }

            // Check that user selected a NPC
            if (listBoxNpc.SelectedIndex == -1)
            {
                // No NPC selected
                return;
            }

            // Validate integer input field
            var validate_integer_field = (string str, int max_length) =>
            {
                // Check that string is not empty
                if (str.Length == 0)
                {
                    return false;
                }

                // Check length
                if (str.Length > max_length)
                {
                    return false;
                }

                // Check that string consists of numbers
                return str.All(char.IsDigit);
            };

            // Validate string input field
            var validate_string_field = (string str, int max_length) =>
            {
                // Check that string is not empty
                if (str.Length == 0)
                {
                    return false;
                }

                // Check length
                if (str.Length > max_length)
                {
                    return false;
                }

                return true;
            };

            // Get fields
            string id_ = textBoxNpcID.Text.Trim();
            string name_ = textBoxNpcName.Text.Trim();
            string model_id_ = textBoxNpcModel.Text.Trim();
            string pos_x_ = textBoxNpcPosX.Text.Trim();
            string pos_y_ = textBoxNpcPosY.Text.Trim();
            string location_ = textBoxNpcLocation.Text.Trim();
            string script_ = textBoxNpcScript.Text.Trim();

            // Validation flag
            int valid = 0;

            // Validate fields
            {
                valid |= (
                       ((validate_integer_field(id_, 4)                                  == true) ? 1 : 0) << 0 |
                       ((validate_string_field(name_, 72)                                == true) ? 1 : 0) << 1 |
                       ((validate_integer_field(model_id_, 6)                            == true) ? 1 : 0) << 2 |
                       (((comboBoxNpcIcon.SelectedIndex != -1  )                         == true) ? 1 : 0) << 3 |
                       ((validate_integer_field(pos_x_, 4)                               == true) ? 1 : 0) << 4 |
                       ((validate_integer_field(pos_y_, 4)                               == true) ? 1 : 0) << 5 |
                       ((( (textNpcAngle.Value >= -360) && (textNpcAngle.Value <= 360) ) == true) ? 1 : 0) << 6 |
                       ((validate_string_field(location_, 72)                            == true) ? 1 : 0) << 7 |
                       ((validate_string_field(script_, 72)                              == true) ? 1 : 0) << 8
                );

                // Update labels colors
                foreach (KeyValuePair<int, Label> pair in Labels)
                {
                    // Check if success bit it set
                    if ((valid & (1 << pair.Key)) != 0)
                    {
                        // Set normal color
                        pair.Value.ForeColor = Color.White;
                    }
                    else
                    {
                        // Set red color
                        pair.Value.ForeColor = Color.Tomato;
                    }
                }
            }

            // Get current NPC
            Npc npc = (Npc)listBoxNpc.SelectedItem;

            // Backup some fields
            int id = npc.Id;
            int icon_id = npc.Icon_id;
            int angle = npc.Angle;
            string name = npc.Name;

            // Update NPC fields
            try
            {
                if ( (valid & (1 << 0)) != 0 ) { npc.Id = int.Parse(id_);                     }
                if ( (valid & (1 << 1)) != 0 ) { npc.Name = name_;                            }
                if ( (valid & (1 << 2)) != 0 ) { npc.Model_id = int.Parse(model_id_);         }
                if ( (valid & (1 << 3)) != 0 ) { npc.Icon_id = comboBoxNpcIcon.SelectedIndex; }
                if ( (valid & (1 << 4)) != 0 ) { npc.Pos_x = int.Parse(pos_x_) * 100;         }
                if ( (valid & (1 << 5)) != 0 ) { npc.Pos_y = int.Parse(pos_y_) * 100;         }
                if ( (valid & (1 << 6)) != 0 ) { npc.Angle = (int)textNpcAngle.Value;         }
                if ( (valid & (1 << 7)) != 0 ) { npc.Location = location_;                    }
                if ( (valid & (1 << 8)) != 0 ) { npc.Script = script_;                        }

                // NPC state is changed
                if (valid != 0)
                {
                    npc.Changed = true;
                }
            }
            catch
            {
                return;
            }

            // Repaint list box with NPCs
            listBoxNpc.Refresh();

            // Repaint group box
            if ( (id != npc.Id) || (name != npc.Name) )
            {
                // Update group box title
                groupBoxMain.Text = string.Format("NPC: {0}", npc.Name);
            }

            // Repaint NPC angle picture
            if (angle != npc.Angle)
            {
                pictureBoxNpcAngle.Refresh();
            }
        }

        // Start update forms programmatically
        public void BeginUpdate()
        {
            Updates++;
        }

        // Stop update forms programmatically
        public void EndUpdate()
        {
            Updates--;
        }

        // Are forms updating programmatically now?
        public bool Updating 
        {
            get { 
                return (Updates > 0); 
            } 
        }

        // Ask if user want to save the NPC list
        private void AskUser()
        {
            // Ask user should the NPC list be saved?
            DialogResult ret = MessageBox.Show("Save NPC list to the file?", "Question",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            // Proccess answer
            if (ret == DialogResult.OK)
            {
                buttonSave.PerformClick();
            }
        }

        // Maximum NPC ID
        private int Max_id = 0;

        // Number of forms updates
        private int Updates = 0;

        // Pen for drawing
        private readonly Pen pen;

        // Input field -> Label map
        private readonly Dictionary<int, Label> Labels;
    }
}
