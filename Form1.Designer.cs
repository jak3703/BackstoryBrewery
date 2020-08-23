using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CharacterWritingForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFile = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.birthday = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bloodType = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.birthplace = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.hairEyeColor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.eyesight = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.handedness = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.voiceType = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.race = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.religion = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pets = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pastimes = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.skills = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.likesDislikes = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.injuries = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.miscPhysical = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.lifeRecords = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.formingExperience = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.loveLife = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.admiresOrHates = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.dreams = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.fears = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.personalityTraits = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.relationships = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(12, 12);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(75, 23);
            this.openFile.TabIndex = 0;
            this.openFile.Text = "Open";
            this.openFile.UseMnemonic = false;
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // saveFile
            // 
            this.saveFile.Location = new System.Drawing.Point(93, 12);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(75, 23);
            this.saveFile.TabIndex = 1;
            this.saveFile.Text = "Save";
            this.saveFile.UseVisualStyleBackColor = true;
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "json";
            this.saveFileDialog1.Filter = "JSON files | *.json";
            this.saveFileDialog1.RestoreDirectory = true;
            this.saveFileDialog1.Title = "Save Character";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name/Nicknames";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(139, 65);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(974, 20);
            this.name.TabIndex = 3;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Age";
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(139, 91);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(974, 20);
            this.age.TabIndex = 5;
            this.age.TextChanged += new System.EventHandler(this.age_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sex/Gender";
            // 
            // sex
            // 
            this.sex.Location = new System.Drawing.Point(139, 117);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(974, 20);
            this.sex.TabIndex = 7;
            this.sex.TextChanged += new System.EventHandler(this.sex_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "JSON files|*.json";
            this.openFileDialog1.Title = "Load Old Character";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // birthday
            // 
            this.birthday.Location = new System.Drawing.Point(139, 143);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(974, 20);
            this.birthday.TabIndex = 10;
            this.birthday.TextChanged += new System.EventHandler(this.bDay_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Birthday/Birthsign";
            // 
            // bloodType
            // 
            this.bloodType.Location = new System.Drawing.Point(139, 169);
            this.bloodType.Name = "bloodType";
            this.bloodType.Size = new System.Drawing.Size(974, 20);
            this.bloodType.TabIndex = 12;
            this.bloodType.TextChanged += new System.EventHandler(this.bloodType_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Blood Type";
            // 
            // birthplace
            // 
            this.birthplace.Location = new System.Drawing.Point(139, 195);
            this.birthplace.Name = "birthplace";
            this.birthplace.Size = new System.Drawing.Size(974, 20);
            this.birthplace.TabIndex = 14;
            this.birthplace.TextChanged += new System.EventHandler(this.birthplace_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Birthplace";
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(139, 221);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(974, 20);
            this.height.TabIndex = 16;
            this.height.TextChanged += new System.EventHandler(this.height_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(95, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Height";
            // 
            // weight
            // 
            this.weight.Location = new System.Drawing.Point(139, 247);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(974, 20);
            this.weight.TabIndex = 18;
            this.weight.TextChanged += new System.EventHandler(this.weight_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(92, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Weight";
            // 
            // hairEyeColor
            // 
            this.hairEyeColor.Location = new System.Drawing.Point(139, 273);
            this.hairEyeColor.Name = "hairEyeColor";
            this.hairEyeColor.Size = new System.Drawing.Size(974, 20);
            this.hairEyeColor.TabIndex = 20;
            this.hairEyeColor.TextChanged += new System.EventHandler(this.hairEyeColor_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Hair/Eye Color";
            // 
            // eyesight
            // 
            this.eyesight.Location = new System.Drawing.Point(139, 301);
            this.eyesight.Multiline = true;
            this.eyesight.Name = "eyesight";
            this.eyesight.Size = new System.Drawing.Size(974, 40);
            this.eyesight.TabIndex = 22;
            this.eyesight.TextChanged += new System.EventHandler(this.eyesight_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(58, 302);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 39);
            this.label10.TabIndex = 21;
            this.label10.Text = "Eyesight/\r\nColorblindness/\r\nGlasses/etc.";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // handedness
            // 
            this.handedness.Location = new System.Drawing.Point(139, 347);
            this.handedness.Name = "handedness";
            this.handedness.Size = new System.Drawing.Size(974, 20);
            this.handedness.TabIndex = 24;
            this.handedness.TextChanged += new System.EventHandler(this.handedness_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(69, 350);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Handedness";
            // 
            // voiceType
            // 
            this.voiceType.Location = new System.Drawing.Point(139, 373);
            this.voiceType.Name = "voiceType";
            this.voiceType.Size = new System.Drawing.Size(974, 20);
            this.voiceType.TabIndex = 26;
            this.voiceType.TextChanged += new System.EventHandler(this.voiceType_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(63, 376);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Type of Voice";
            // 
            // race
            // 
            this.race.Location = new System.Drawing.Point(139, 399);
            this.race.Name = "race";
            this.race.Size = new System.Drawing.Size(974, 20);
            this.race.TabIndex = 28;
            this.race.TextChanged += new System.EventHandler(this.race_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(100, 402);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Race";
            // 
            // religion
            // 
            this.religion.Location = new System.Drawing.Point(139, 425);
            this.religion.Multiline = true;
            this.religion.Name = "religion";
            this.religion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.religion.Size = new System.Drawing.Size(974, 100);
            this.religion.TabIndex = 30;
            this.religion.TextChanged += new System.EventHandler(this.religion_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(88, 432);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Religion";
            // 
            // pets
            // 
            this.pets.Location = new System.Drawing.Point(139, 531);
            this.pets.Multiline = true;
            this.pets.Name = "pets";
            this.pets.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.pets.Size = new System.Drawing.Size(974, 100);
            this.pets.TabIndex = 32;
            this.pets.TextChanged += new System.EventHandler(this.pets_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(74, 531);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Pets/Plants";
            // 
            // pastimes
            // 
            this.pastimes.Location = new System.Drawing.Point(139, 637);
            this.pastimes.Multiline = true;
            this.pastimes.Name = "pastimes";
            this.pastimes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.pastimes.Size = new System.Drawing.Size(974, 100);
            this.pastimes.TabIndex = 34;
            this.pastimes.TextChanged += new System.EventHandler(this.pastimes_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 637);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(130, 26);
            this.label16.TabIndex = 33;
            this.label16.Text = "Employment, Recreations,\r\nHobbies, Pastimes, etc.";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // skills
            // 
            this.skills.Location = new System.Drawing.Point(139, 743);
            this.skills.Multiline = true;
            this.skills.Name = "skills";
            this.skills.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.skills.Size = new System.Drawing.Size(974, 100);
            this.skills.TabIndex = 36;
            this.skills.TextChanged += new System.EventHandler(this.skills_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(23, 743);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(113, 26);
            this.label17.TabIndex = 35;
            this.label17.Text = "Special Skills, Powers,\r\nFighting Styles, etc.";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // likesDislikes
            // 
            this.likesDislikes.Location = new System.Drawing.Point(139, 849);
            this.likesDislikes.Multiline = true;
            this.likesDislikes.Name = "likesDislikes";
            this.likesDislikes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.likesDislikes.Size = new System.Drawing.Size(974, 100);
            this.likesDislikes.TabIndex = 38;
            this.likesDislikes.TextChanged += new System.EventHandler(this.likesDislikes_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(33, 849);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(103, 52);
            this.label18.TabIndex = 39;
            this.label18.Text = "Likes/Dislikes:\r\nfood, alcohol, drugs,\r\nfashion, music,\r\nbrands, etc.";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // injuries
            // 
            this.injuries.Location = new System.Drawing.Point(139, 955);
            this.injuries.Multiline = true;
            this.injuries.Name = "injuries";
            this.injuries.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.injuries.Size = new System.Drawing.Size(974, 100);
            this.injuries.TabIndex = 40;
            this.injuries.TextChanged += new System.EventHandler(this.injuries_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(10, 958);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(126, 39);
            this.label19.TabIndex = 41;
            this.label19.Text = "History of Surgeries,\r\nScars, Cavities, Illnesses,\r\nBurns/Skin Damage";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // miscPhysical
            // 
            this.miscPhysical.Location = new System.Drawing.Point(139, 1061);
            this.miscPhysical.Multiline = true;
            this.miscPhysical.Name = "miscPhysical";
            this.miscPhysical.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.miscPhysical.Size = new System.Drawing.Size(974, 100);
            this.miscPhysical.TabIndex = 42;
            this.miscPhysical.TextChanged += new System.EventHandler(this.miscPhysical_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(2, 1064);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(134, 65);
            this.label21.TabIndex = 44;
            this.label21.Text = "Physical Characteristics:\r\n\r\nNose/Eye Shape, Posture,\r\nAttractiveness, Birthmarks" +
    ",\r\nTattoos, etc.";
            this.label21.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lifeRecords
            // 
            this.lifeRecords.Location = new System.Drawing.Point(139, 1167);
            this.lifeRecords.Multiline = true;
            this.lifeRecords.Name = "lifeRecords";
            this.lifeRecords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lifeRecords.Size = new System.Drawing.Size(974, 100);
            this.lifeRecords.TabIndex = 45;
            this.lifeRecords.TextChanged += new System.EventHandler(this.lifeRecords_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(50, 1170);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(86, 39);
            this.label20.TabIndex = 46;
            this.label20.Text = "Education/\r\nAwards/\r\nCriminal Records";
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // formingExperience
            // 
            this.formingExperience.Location = new System.Drawing.Point(139, 1273);
            this.formingExperience.Multiline = true;
            this.formingExperience.Name = "formingExperience";
            this.formingExperience.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.formingExperience.Size = new System.Drawing.Size(974, 100);
            this.formingExperience.TabIndex = 47;
            this.formingExperience.TextChanged += new System.EventHandler(this.formingExpoerience_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(31, 1273);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(105, 52);
            this.label22.TabIndex = 48;
            this.label22.Text = "Forming Experiences\r\nas a Child/Infant\r\n(including who\r\nwas involved)";
            this.label22.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // loveLife
            // 
            this.loveLife.Location = new System.Drawing.Point(139, 1379);
            this.loveLife.Multiline = true;
            this.loveLife.Name = "loveLife";
            this.loveLife.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.loveLife.Size = new System.Drawing.Size(974, 100);
            this.loveLife.TabIndex = 49;
            this.loveLife.TextChanged += new System.EventHandler(this.loveLife_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(44, 1379);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(92, 39);
            this.label23.TabIndex = 50;
            this.label23.Text = "Love Life, Lovers,\r\nThoughts about \r\nLove/Marriage";
            this.label23.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // admiresOrHates
            // 
            this.admiresOrHates.Location = new System.Drawing.Point(139, 1485);
            this.admiresOrHates.Multiline = true;
            this.admiresOrHates.Name = "admiresOrHates";
            this.admiresOrHates.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.admiresOrHates.Size = new System.Drawing.Size(974, 100);
            this.admiresOrHates.TabIndex = 51;
            this.admiresOrHates.TextChanged += new System.EventHandler(this.admiresOrHates_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(29, 1488);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(107, 26);
            this.label24.TabIndex = 52;
            this.label24.Text = "People the Character\r\nAdmires or Hates";
            this.label24.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dreams
            // 
            this.dreams.Location = new System.Drawing.Point(139, 1591);
            this.dreams.Multiline = true;
            this.dreams.Name = "dreams";
            this.dreams.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dreams.Size = new System.Drawing.Size(974, 100);
            this.dreams.TabIndex = 53;
            this.dreams.TextChanged += new System.EventHandler(this.dreams_TextChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(27, 1591);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(109, 13);
            this.label25.TabIndex = 54;
            this.label25.Text = "Dreams for the Future";
            this.label25.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // fears
            // 
            this.fears.Location = new System.Drawing.Point(139, 1697);
            this.fears.Multiline = true;
            this.fears.Name = "fears";
            this.fears.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.fears.Size = new System.Drawing.Size(974, 100);
            this.fears.TabIndex = 55;
            this.fears.TextChanged += new System.EventHandler(this.fears_TextChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(16, 1700);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(120, 26);
            this.label26.TabIndex = 56;
            this.label26.Text = "Fears/Anxieties\r\n(physical, irrational, etc.)";
            this.label26.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // personalityTraits
            // 
            this.personalityTraits.Location = new System.Drawing.Point(139, 1803);
            this.personalityTraits.Multiline = true;
            this.personalityTraits.Name = "personalityTraits";
            this.personalityTraits.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.personalityTraits.Size = new System.Drawing.Size(974, 100);
            this.personalityTraits.TabIndex = 57;
            this.personalityTraits.TextChanged += new System.EventHandler(this.personalityTraits_TextChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(12, 1806);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(124, 65);
            this.label27.TabIndex = 58;
            this.label27.Text = "Personality Traits:\r\n\r\nFavorite Sayings, Habits,\r\nStrengths/Weaknesses,\r\netc.";
            this.label27.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // relationships
            // 
            this.relationships.Location = new System.Drawing.Point(139, 1909);
            this.relationships.Multiline = true;
            this.relationships.Name = "relationships";
            this.relationships.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.relationships.Size = new System.Drawing.Size(974, 100);
            this.relationships.TabIndex = 59;
            this.relationships.TextChanged += new System.EventHandler(this.relationships_TextChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 1909);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(130, 52);
            this.label28.TabIndex = 60;
            this.label28.Text = "Significant Relationships:\r\n\r\nFamily, Friends, Romantic,\r\nmentor, problematic, et" +
    "c.";
            this.label28.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1201, 721);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.relationships);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.personalityTraits);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.fears);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.dreams);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.admiresOrHates);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.loveLife);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.formingExperience);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lifeRecords);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.miscPhysical);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.injuries);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.likesDislikes);
            this.Controls.Add(this.skills);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.pastimes);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.pets);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.religion);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.race);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.voiceType);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.handedness);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.eyesight);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.hairEyeColor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.height);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.birthplace);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bloodType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.age);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveFile);
            this.Controls.Add(this.openFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1200, 760);
            this.MinimumSize = new System.Drawing.Size(1200, 760);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backstory Brewery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.Button saveFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sex;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox birthday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bloodType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox birthplace;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox hairEyeColor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox eyesight;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox handedness;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox voiceType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox race;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox religion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox pets;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox pastimes;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox skills;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox likesDislikes;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox injuries;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox miscPhysical;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox lifeRecords;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox formingExperience;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox loveLife;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox admiresOrHates;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox dreams;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox fears;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox personalityTraits;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox relationships;
        private System.Windows.Forms.Label label28;
    }
}

