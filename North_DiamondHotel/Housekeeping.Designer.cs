
namespace North_DiamondHotel
{
    partial class Housekeeping
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
            this.panelHouseKeeping = new System.Windows.Forms.Panel();
            this.viewRoomsCursor = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.logOutCursor = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.logoPicture = new System.Windows.Forms.PictureBox();
            this.viewRoomsbutton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.staffNameLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.welcomeLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.viewRoomsPanel = new System.Windows.Forms.Panel();
            this.congratsLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.markCleanButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.miniLogoPicture = new System.Windows.Forms.PictureBox();
            this.roomsLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.roomsToBeCleanedGrid = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelHouseKeeping.SuspendLayout();
            this.viewRoomsCursor.SuspendLayout();
            this.logOutCursor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.viewRoomsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.miniLogoPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsToBeCleanedGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHouseKeeping
            // 
            this.panelHouseKeeping.BackColor = System.Drawing.SystemColors.ControlText;
            this.panelHouseKeeping.Controls.Add(this.viewRoomsCursor);
            this.panelHouseKeeping.Controls.Add(this.logOutCursor);
            this.panelHouseKeeping.Controls.Add(this.logoPicture);
            this.panelHouseKeeping.Controls.Add(this.viewRoomsbutton);
            this.panelHouseKeeping.Controls.Add(this.logOutButton);
            this.panelHouseKeeping.Location = new System.Drawing.Point(2, 2);
            this.panelHouseKeeping.Name = "panelHouseKeeping";
            this.panelHouseKeeping.Size = new System.Drawing.Size(209, 1000);
            this.panelHouseKeeping.TabIndex = 2;
            // 
            // viewRoomsCursor
            // 
            this.viewRoomsCursor.BackColor = System.Drawing.Color.BlueViolet;
            this.viewRoomsCursor.Controls.Add(this.panel5);
            this.viewRoomsCursor.Location = new System.Drawing.Point(3, 214);
            this.viewRoomsCursor.Name = "viewRoomsCursor";
            this.viewRoomsCursor.Size = new System.Drawing.Size(17, 46);
            this.viewRoomsCursor.TabIndex = 10;
            this.viewRoomsCursor.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Goldenrod;
            this.panel5.Location = new System.Drawing.Point(-92, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(17, 46);
            this.panel5.TabIndex = 2;
            // 
            // logOutCursor
            // 
            this.logOutCursor.BackColor = System.Drawing.Color.DarkOrchid;
            this.logOutCursor.Controls.Add(this.panel7);
            this.logOutCursor.Location = new System.Drawing.Point(3, 266);
            this.logOutCursor.Name = "logOutCursor";
            this.logOutCursor.Size = new System.Drawing.Size(17, 46);
            this.logOutCursor.TabIndex = 7;
            this.logOutCursor.Visible = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Goldenrod;
            this.panel7.Location = new System.Drawing.Point(-92, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(17, 46);
            this.panel7.TabIndex = 2;
            // 
            // logoPicture
            // 
            this.logoPicture.Image = global::North_DiamondHotel.Properties.Resources.logo_white1;
            this.logoPicture.Location = new System.Drawing.Point(20, 0);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.Size = new System.Drawing.Size(164, 152);
            this.logoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPicture.TabIndex = 3;
            this.logoPicture.TabStop = false;
            this.logoPicture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // viewRoomsbutton
            // 
            this.viewRoomsbutton.FlatAppearance.BorderSize = 0;
            this.viewRoomsbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.viewRoomsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewRoomsbutton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewRoomsbutton.ForeColor = System.Drawing.Color.BlueViolet;
            this.viewRoomsbutton.Location = new System.Drawing.Point(3, 214);
            this.viewRoomsbutton.Name = "viewRoomsbutton";
            this.viewRoomsbutton.Size = new System.Drawing.Size(200, 46);
            this.viewRoomsbutton.TabIndex = 12;
            this.viewRoomsbutton.Text = "View Rooms";
            this.viewRoomsbutton.UseVisualStyleBackColor = true;
            this.viewRoomsbutton.Click += new System.EventHandler(this.viewRoomsbutton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.FlatAppearance.BorderSize = 0;
            this.logOutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.ForeColor = System.Drawing.Color.DarkOrchid;
            this.logOutButton.Location = new System.Drawing.Point(3, 266);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(200, 46);
            this.logOutButton.TabIndex = 8;
            this.logOutButton.Text = "Log Out\r\n";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // staffNameLabel
            // 
            this.staffNameLabel.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ItalicControl;
            this.staffNameLabel.Location = new System.Drawing.Point(466, 76);
            this.staffNameLabel.Name = "staffNameLabel";
            this.staffNameLabel.Size = new System.Drawing.Size(54, 17);
            this.staffNameLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.DarkOrchid;
            this.staffNameLabel.StateCommon.ShortText.Color2 = System.Drawing.Color.DarkOrchid;
            this.staffNameLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffNameLabel.TabIndex = 5;
            this.staffNameLabel.Values.Text = "(name)";
            this.staffNameLabel.Visible = false;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ItalicControl;
            this.welcomeLabel.Location = new System.Drawing.Point(378, 76);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(67, 20);
            this.welcomeLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.DarkOrchid;
            this.welcomeLabel.StateCommon.ShortText.Color2 = System.Drawing.Color.DarkOrchid;
            this.welcomeLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.TabIndex = 4;
            this.welcomeLabel.Values.Text = "Welcome\r\n";
            // 
            // viewRoomsPanel
            // 
            this.viewRoomsPanel.Controls.Add(this.congratsLabel);
            this.viewRoomsPanel.Controls.Add(this.markCleanButton);
            this.viewRoomsPanel.Controls.Add(this.miniLogoPicture);
            this.viewRoomsPanel.Controls.Add(this.roomsLabel);
            this.viewRoomsPanel.Controls.Add(this.roomsToBeCleanedGrid);
            this.viewRoomsPanel.Location = new System.Drawing.Point(227, 2);
            this.viewRoomsPanel.Name = "viewRoomsPanel";
            this.viewRoomsPanel.Size = new System.Drawing.Size(500, 503);
            this.viewRoomsPanel.TabIndex = 7;
            this.viewRoomsPanel.Visible = false;
            this.viewRoomsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.homePagePanel_Paint);
            // 
            // congratsLabel
            // 
            this.congratsLabel.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.congratsLabel.Location = new System.Drawing.Point(21, 220);
            this.congratsLabel.Name = "congratsLabel";
            this.congratsLabel.Size = new System.Drawing.Size(367, 22);
            this.congratsLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.DarkOrchid;
            this.congratsLabel.StateCommon.ShortText.Color2 = System.Drawing.Color.DarkOrchid;
            this.congratsLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Bahnschrift SemiBold", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.congratsLabel.StateNormal.ShortText.Color1 = System.Drawing.Color.DarkOrchid;
            this.congratsLabel.StateNormal.ShortText.Color2 = System.Drawing.Color.DarkOrchid;
            this.congratsLabel.StateNormal.ShortText.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.congratsLabel.TabIndex = 11;
            this.congratsLabel.Values.Text = "You have no more rooms to clean. Good Job!";
            this.congratsLabel.Visible = false;
            // 
            // markCleanButton
            // 
            this.markCleanButton.Location = new System.Drawing.Point(151, 369);
            this.markCleanButton.Name = "markCleanButton";
            this.markCleanButton.OverrideDefault.Back.Color1 = System.Drawing.Color.Black;
            this.markCleanButton.OverrideDefault.Back.Color2 = System.Drawing.Color.Black;
            this.markCleanButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.markCleanButton.OverrideDefault.Border.Rounding = 20;
            this.markCleanButton.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.DarkOrchid;
            this.markCleanButton.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.DarkOrchid;
            this.markCleanButton.Size = new System.Drawing.Size(331, 47);
            this.markCleanButton.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.markCleanButton.StateCommon.Back.Color2 = System.Drawing.Color.Black;
            this.markCleanButton.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.markCleanButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.markCleanButton.StateCommon.Border.Rounding = 20;
            this.markCleanButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.markCleanButton.StateDisabled.Back.Color1 = System.Drawing.Color.CornflowerBlue;
            this.markCleanButton.StateDisabled.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.markCleanButton.StateNormal.Back.Color1 = System.Drawing.Color.Black;
            this.markCleanButton.StateNormal.Back.Color2 = System.Drawing.Color.Black;
            this.markCleanButton.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.markCleanButton.StateNormal.Border.Rounding = 20;
            this.markCleanButton.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.DarkOrchid;
            this.markCleanButton.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.DarkOrchid;
            this.markCleanButton.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.markCleanButton.StatePressed.Back.Color1 = System.Drawing.Color.RoyalBlue;
            this.markCleanButton.StatePressed.Back.Color2 = System.Drawing.Color.RoyalBlue;
            this.markCleanButton.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.markCleanButton.StatePressed.Border.Rounding = 20;
            this.markCleanButton.StateTracking.Back.Color1 = System.Drawing.Color.CornflowerBlue;
            this.markCleanButton.StateTracking.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.markCleanButton.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.markCleanButton.StateTracking.Border.Color2 = System.Drawing.Color.Transparent;
            this.markCleanButton.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.markCleanButton.StateTracking.Border.Rounding = 20;
            this.markCleanButton.TabIndex = 10;
            this.markCleanButton.Values.Text = "Mark Selected Room as Cleaned";
            this.markCleanButton.Click += new System.EventHandler(this.markCleanButton_Click);
            // 
            // miniLogoPicture
            // 
            this.miniLogoPicture.Image = global::North_DiamondHotel.Properties.Resources.logo_no_background1;
            this.miniLogoPicture.Location = new System.Drawing.Point(387, 34);
            this.miniLogoPicture.Name = "miniLogoPicture";
            this.miniLogoPicture.Size = new System.Drawing.Size(106, 65);
            this.miniLogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.miniLogoPicture.TabIndex = 9;
            this.miniLogoPicture.TabStop = false;
            // 
            // roomsLabel
            // 
            this.roomsLabel.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.roomsLabel.Location = new System.Drawing.Point(31, 68);
            this.roomsLabel.Name = "roomsLabel";
            this.roomsLabel.Size = new System.Drawing.Size(214, 17);
            this.roomsLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.DarkOrchid;
            this.roomsLabel.StateCommon.ShortText.Color2 = System.Drawing.Color.DarkOrchid;
            this.roomsLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomsLabel.StateNormal.ShortText.Color1 = System.Drawing.Color.DarkOrchid;
            this.roomsLabel.StateNormal.ShortText.Color2 = System.Drawing.Color.DarkOrchid;
            this.roomsLabel.StateNormal.ShortText.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomsLabel.TabIndex = 8;
            this.roomsLabel.Values.Text = "The rooms you have to clean are: ";
            // 
            // roomsToBeCleanedGrid
            // 
            this.roomsToBeCleanedGrid.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.roomsToBeCleanedGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roomsToBeCleanedGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomsToBeCleanedGrid.Location = new System.Drawing.Point(49, 105);
            this.roomsToBeCleanedGrid.Name = "roomsToBeCleanedGrid";
            this.roomsToBeCleanedGrid.RowHeadersWidth = 62;
            this.roomsToBeCleanedGrid.RowTemplate.Height = 28;
            this.roomsToBeCleanedGrid.Size = new System.Drawing.Size(414, 247);
            this.roomsToBeCleanedGrid.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::North_DiamondHotel.Properties.Resources.logo_no_background1;
            this.pictureBox1.Location = new System.Drawing.Point(276, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(362, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Housekeeping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(732, 503);
            this.Controls.Add(this.viewRoomsPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.staffNameLabel);
            this.Controls.Add(this.panelHouseKeeping);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Housekeeping";
            this.Text = "HouseKeeping";
            this.Load += new System.EventHandler(this.Housekeeping_Load);
            this.panelHouseKeeping.ResumeLayout(false);
            this.viewRoomsCursor.ResumeLayout(false);
            this.logOutCursor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.viewRoomsPanel.ResumeLayout(false);
            this.viewRoomsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.miniLogoPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsToBeCleanedGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelHouseKeeping;
        private System.Windows.Forms.PictureBox logoPicture;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel welcomeLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel staffNameLabel;
        private System.Windows.Forms.Panel viewRoomsPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel viewRoomsCursor;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel logOutCursor;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button viewRoomsbutton;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel congratsLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton markCleanButton;
        private System.Windows.Forms.PictureBox miniLogoPicture;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel roomsLabel;
        private System.Windows.Forms.DataGridView roomsToBeCleanedGrid;
    }
}