using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CharacterWritingForm
{
    public partial class Form1 : Form
    {

        private Dictionary<string, string> formData;
        private Dictionary<string, TextBox> textboxes;

        public Form1()
        {
            InitializeComponent();
            saveFileDialog1.FileName = "Character";

            formData = new Dictionary<string, string>();
            formData[name.Name] = "";
            formData[age.Name] = "";
            formData[sex.Name] = "";
            formData[birthday.Name] = "";
            formData[bloodType.Name] = "";
            formData[birthplace.Name] = "";
            formData[height.Name] = "";
            formData[weight.Name] = "";
            formData[hairEyeColor.Name] = "";
            formData[eyesight.Name] = "";
            formData[handedness.Name] = "";
            formData[voiceType.Name] = "";
            formData[race.Name] = "";
            formData[religion.Name] = "";
            formData[pets.Name] = "";
            formData[pastimes.Name] = "";
            formData[skills.Name] = "";
            formData[likesDislikes.Name] = "";
            formData[injuries.Name] = "";
            formData[miscPhysical.Name] = "";
            formData[lifeRecords.Name] = "";
            formData[formingExperience.Name] = "";
            formData[loveLife.Name] = "";
            formData[admiresOrHates.Name] = "";
            formData[dreams.Name] = "";
            formData[fears.Name] = "";
            formData[personalityTraits.Name] = "";
            formData[relationships.Name] = "";

            textboxes = new Dictionary<string, TextBox>();
            textboxes[name.Name] = name;
            textboxes[age.Name] = age;
            textboxes[sex.Name] = sex;
            textboxes[birthday.Name] = birthday;
            textboxes[bloodType.Name] = bloodType;
            textboxes[birthplace.Name] = birthplace;
            textboxes[height.Name] = height;
            textboxes[weight.Name] = weight;
            textboxes[hairEyeColor.Name] = hairEyeColor;
            textboxes[eyesight.Name] = eyesight;
            textboxes[handedness.Name] = handedness;
            textboxes[voiceType.Name] = voiceType;
            textboxes[race.Name] = race;
            textboxes[religion.Name] = religion;
            textboxes[pets.Name] = pets;
            textboxes[pastimes.Name] = pastimes;
            textboxes[skills.Name] = skills;
            textboxes[likesDislikes.Name] = likesDislikes;
            textboxes[injuries.Name] = injuries;
            textboxes[miscPhysical.Name] = miscPhysical;
            textboxes[lifeRecords.Name] = lifeRecords;
            textboxes[formingExperience.Name] = formingExperience;
            textboxes[loveLife.Name] = loveLife;
            textboxes[admiresOrHates.Name] = admiresOrHates;
            textboxes[dreams.Name] = dreams;
            textboxes[fears.Name] = fears;
            textboxes[personalityTraits.Name] = personalityTraits;
            textboxes[relationships.Name] = relationships;
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string f = saveFileDialog1.FileName;
            FileStream stream = new FileStream(f, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write);
            string jsonStr = JsonConvert.SerializeObject(formData);
            foreach(char c in jsonStr)
            {
                stream.WriteByte((byte)c);
            }
            stream.Close();
            string[] toks = f.Split('\\');
            saveFileDialog1.FileName = toks[toks.Length-1];
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (!openFileDialog1.FileName.EndsWith(".json"))
            {
                MessageBox.Show("Error: Invalid file type.");
            }
            try
            {
                FileStream stream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                string jsonStr = "";
                int cur;
                while (true)
                {
                    cur = stream.ReadByte();
                    if(cur == -1)
                    {
                        break;
                    }
                    jsonStr += (char)cur;
                }
                stream.Close();

                Dictionary<string, string> tmp = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonStr);
                
                foreach(string key in formData.Keys)
                {
                    string test = tmp[key];
                }

                formData = tmp;
            }catch(FileNotFoundException fnfe)
            {
                MessageBox.Show("Error: File not found.");
                return;
            }catch(JsonSerializationException jse)
            {
                MessageBox.Show("Error: File data could not be parsed.");
                return;
            }catch(KeyNotFoundException kne)
            {
                MessageBox.Show("Error: File contains invalid fields.");
                return;
            }

            foreach(string key in textboxes.Keys){
                textboxes[key].Text = formData[key];
            }

            string[] toks = openFileDialog1.FileName.Split('\\');
            saveFileDialog1.FileName = toks[toks.Length - 1];
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            formData[name.Name] = name.Text;
            if (name.Text.Equals(""))
            {
                saveFileDialog1.FileName = "Character";
            }
            else
            {
                saveFileDialog1.FileName = name.Text;
            }
        }

        private void age_TextChanged(object sender, EventArgs e)
        {
            formData[age.Name] = age.Text;
        }

        private void sex_TextChanged(object sender, EventArgs e)
        {
            formData[sex.Name] = sex.Text;
        }

        private void bDay_TextChanged(object sender, EventArgs e)
        {
            formData[birthday.Name] = birthday.Text;
        }

        private void bloodType_TextChanged(object sender, EventArgs e)
        {
            formData[bloodType.Name] = bloodType.Text;
        }

        private void birthplace_TextChanged(object sender, EventArgs e)
        {
            formData[birthplace.Name] = birthplace.Text;
        }

        private void height_TextChanged(object sender, EventArgs e)
        {
            formData[height.Name] = height.Text;
        }

        private void weight_TextChanged(object sender, EventArgs e)
        {
            formData[weight.Name] = weight.Text;
        }

        private void hairEyeColor_TextChanged(object sender, EventArgs e)
        {
            formData[hairEyeColor.Name] = hairEyeColor.Text;
        }

        private void eyesight_TextChanged(object sender, EventArgs e)
        {
            formData[eyesight.Name] = eyesight.Text;
        }

        private void handedness_TextChanged(object sender, EventArgs e)
        {
            formData[handedness.Name] = handedness.Text;
        }

        private void voiceType_TextChanged(object sender, EventArgs e)
        {
            formData[voiceType.Name] = voiceType.Text;
        }

        private void race_TextChanged(object sender, EventArgs e)
        {
            formData[race.Name] = race.Text;
        }

        private void religion_TextChanged(object sender, EventArgs e)
        {
            formData[religion.Name] = religion.Text;
        }

        private void pets_TextChanged(object sender, EventArgs e)
        {
            formData[pets.Name] = pets.Text;
        }

        private void pastimes_TextChanged(object sender, EventArgs e)
        {
            formData[pastimes.Name] = pastimes.Text;
        }

        private void skills_TextChanged(object sender, EventArgs e)
        {
            formData[skills.Name] = skills.Text;
        }

        private void likesDislikes_TextChanged(object sender, EventArgs e)
        {
            formData[likesDislikes.Name] = likesDislikes.Text;
        }

        private void injuries_TextChanged(object sender, EventArgs e)
        {
            formData[injuries.Name] = injuries.Text;
        }

        private void miscPhysical_TextChanged(object sender, EventArgs e)
        {
            formData[miscPhysical.Name] = miscPhysical.Text;
        }

        private void lifeRecords_TextChanged(object sender, EventArgs e)
        {
            formData[lifeRecords.Name] = lifeRecords.Text;
        }

        private void formingExpoerience_TextChanged(object sender, EventArgs e)
        {
            formData[formingExperience.Name] = formingExperience.Text;
        }

        private void loveLife_TextChanged(object sender, EventArgs e)
        {
            formData[loveLife.Name] = loveLife.Text;
        }

        private void admiresOrHates_TextChanged(object sender, EventArgs e)
        {
            formData[admiresOrHates.Name] = admiresOrHates.Text;
        }

        private void dreams_TextChanged(object sender, EventArgs e)
        {
            formData[dreams.Name] = dreams.Text;
        }

        private void fears_TextChanged(object sender, EventArgs e)
        {
            formData[fears.Name] = fears.Text;
        }

        private void personalityTraits_TextChanged(object sender, EventArgs e)
        {
            formData[personalityTraits.Name] = personalityTraits.Text;
        }

        private void relationships_TextChanged(object sender, EventArgs e)
        {
            formData[relationships.Name] = relationships.Text;
        }
    }
}
