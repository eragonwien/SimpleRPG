using System;

namespace LeRPGGame
{
    partial class SimpleRPG
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblEXP = new System.Windows.Forms.Label();
            this.lblSelectAction = new System.Windows.Forms.Label();
            this.cboxWeapon = new System.Windows.Forms.ComboBox();
            this.cboxPotion = new System.Windows.Forms.ComboBox();
            this.btnUseWeapon = new System.Windows.Forms.Button();
            this.btnUsePotion = new System.Windows.Forms.Button();
            this.btnNorth = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.btnSouth = new System.Windows.Forms.Button();
            this.btnOst = new System.Windows.Forms.Button();
            this.rtbLocation = new System.Windows.Forms.RichTextBox();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.dgvQuestLog = new System.Windows.Forms.DataGridView();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.lblMoveCounter = new System.Windows.Forms.Label();
            this.lblMoveCounterValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "HP :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gold :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "EXP :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Level :";
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Location = new System.Drawing.Point(110, 19);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(49, 13);
            this.lblHP.TabIndex = 5;
            this.lblHP.Text = "HPValue";
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.Location = new System.Drawing.Point(110, 45);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(56, 13);
            this.lblGold.TabIndex = 6;
            this.lblGold.Text = "GoldValue";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(110, 99);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(60, 13);
            this.lblLevel.TabIndex = 7;
            this.lblLevel.Text = "LevelValue";
            // 
            // lblEXP
            // 
            this.lblEXP.AutoSize = true;
            this.lblEXP.Location = new System.Drawing.Point(110, 73);
            this.lblEXP.Name = "lblEXP";
            this.lblEXP.Size = new System.Drawing.Size(55, 13);
            this.lblEXP.TabIndex = 8;
            this.lblEXP.Text = "EXPValue";
            // 
            // lblSelectAction
            // 
            this.lblSelectAction.AutoSize = true;
            this.lblSelectAction.Location = new System.Drawing.Point(675, 443);
            this.lblSelectAction.Name = "lblSelectAction";
            this.lblSelectAction.Size = new System.Drawing.Size(70, 13);
            this.lblSelectAction.TabIndex = 9;
            this.lblSelectAction.Text = "Select Action";
            // 
            // cboxWeapon
            // 
            this.cboxWeapon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxWeapon.FormattingEnabled = true;
            this.cboxWeapon.Location = new System.Drawing.Point(506, 470);
            this.cboxWeapon.Name = "cboxWeapon";
            this.cboxWeapon.Size = new System.Drawing.Size(121, 21);
            this.cboxWeapon.TabIndex = 10;
            // 
            // cboxPotion
            // 
            this.cboxPotion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxPotion.FormattingEnabled = true;
            this.cboxPotion.Location = new System.Drawing.Point(506, 513);
            this.cboxPotion.Name = "cboxPotion";
            this.cboxPotion.Size = new System.Drawing.Size(121, 21);
            this.cboxPotion.TabIndex = 11;
            // 
            // btnUseWeapon
            // 
            this.btnUseWeapon.Location = new System.Drawing.Point(670, 470);
            this.btnUseWeapon.Name = "btnUseWeapon";
            this.btnUseWeapon.Size = new System.Drawing.Size(91, 23);
            this.btnUseWeapon.TabIndex = 12;
            this.btnUseWeapon.Text = "Use";
            this.btnUseWeapon.UseVisualStyleBackColor = true;
            this.btnUseWeapon.Click += new System.EventHandler(this.btnUseWeapon_Click);
            // 
            // btnUsePotion
            // 
            this.btnUsePotion.Location = new System.Drawing.Point(670, 511);
            this.btnUsePotion.Name = "btnUsePotion";
            this.btnUsePotion.Size = new System.Drawing.Size(91, 23);
            this.btnUsePotion.TabIndex = 13;
            this.btnUsePotion.Text = "Heal";
            this.btnUsePotion.UseVisualStyleBackColor = true;
            this.btnUsePotion.Click += new System.EventHandler(this.btnUsePotion_Click);
            // 
            // btnNorth
            // 
            this.btnNorth.Location = new System.Drawing.Point(552, 349);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(75, 23);
            this.btnNorth.TabIndex = 14;
            this.btnNorth.Text = "North";
            this.btnNorth.UseVisualStyleBackColor = true;
            this.btnNorth.Click += new System.EventHandler(this.btnNorth_Click);
            // 
            // btnWest
            // 
            this.btnWest.Location = new System.Drawing.Point(478, 378);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(75, 23);
            this.btnWest.TabIndex = 15;
            this.btnWest.Text = "West";
            this.btnWest.UseVisualStyleBackColor = true;
            this.btnWest.Click += new System.EventHandler(this.btnWest_Click);
            // 
            // btnSouth
            // 
            this.btnSouth.Location = new System.Drawing.Point(552, 407);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(75, 23);
            this.btnSouth.TabIndex = 16;
            this.btnSouth.Text = "South";
            this.btnSouth.UseVisualStyleBackColor = true;
            this.btnSouth.Click += new System.EventHandler(this.btnSouth_Click);
            // 
            // btnOst
            // 
            this.btnOst.Location = new System.Drawing.Point(626, 378);
            this.btnOst.Name = "btnOst";
            this.btnOst.Size = new System.Drawing.Size(75, 23);
            this.btnOst.TabIndex = 17;
            this.btnOst.Text = "Ost";
            this.btnOst.UseVisualStyleBackColor = true;
            this.btnOst.Click += new System.EventHandler(this.btnOst_Click);
            // 
            // rtbLocation
            // 
            this.rtbLocation.Location = new System.Drawing.Point(406, 17);
            this.rtbLocation.Name = "rtbLocation";
            this.rtbLocation.ReadOnly = true;
            this.rtbLocation.Size = new System.Drawing.Size(355, 55);
            this.rtbLocation.TabIndex = 18;
            this.rtbLocation.Text = "";
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(406, 96);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(355, 233);
            this.rtbLog.TabIndex = 19;
            this.rtbLog.Text = "";
            this.rtbLog.TextChanged += new System.EventHandler(this.rtbLog_OnTextChanged);
            // 
            // dgvQuestLog
            // 
            this.dgvQuestLog.AllowUserToAddRows = false;
            this.dgvQuestLog.AllowUserToDeleteRows = false;
            this.dgvQuestLog.AllowUserToResizeRows = false;
            this.dgvQuestLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestLog.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvQuestLog.Enabled = false;
            this.dgvQuestLog.Location = new System.Drawing.Point(21, 349);
            this.dgvQuestLog.MultiSelect = false;
            this.dgvQuestLog.Name = "dgvQuestLog";
            this.dgvQuestLog.ReadOnly = true;
            this.dgvQuestLog.RowHeadersVisible = false;
            this.dgvQuestLog.Size = new System.Drawing.Size(344, 185);
            this.dgvQuestLog.TabIndex = 21;
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.AllowUserToResizeRows = false;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInventory.Enabled = false;
            this.dgvInventory.Location = new System.Drawing.Point(21, 144);
            this.dgvInventory.MultiSelect = false;
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.RowHeadersVisible = false;
            this.dgvInventory.Size = new System.Drawing.Size(344, 185);
            this.dgvInventory.TabIndex = 22;
            // 
            // lblMoveCounter
            // 
            this.lblMoveCounter.AutoSize = true;
            this.lblMoveCounter.Location = new System.Drawing.Point(262, 19);
            this.lblMoveCounter.Name = "lblMoveCounter";
            this.lblMoveCounter.Size = new System.Drawing.Size(40, 13);
            this.lblMoveCounter.TabIndex = 23;
            this.lblMoveCounter.Text = "Move :";
            // 
            // lblMoveCounterValue
            // 
            this.lblMoveCounterValue.AutoSize = true;
            this.lblMoveCounterValue.Location = new System.Drawing.Point(316, 20);
            this.lblMoveCounterValue.Name = "lblMoveCounterValue";
            this.lblMoveCounterValue.Size = new System.Drawing.Size(49, 13);
            this.lblMoveCounterValue.TabIndex = 24;
            this.lblMoveCounterValue.Text = "HPValue";
            // 
            // SimpleRPG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblMoveCounterValue);
            this.Controls.Add(this.lblMoveCounter);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.dgvQuestLog);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.rtbLocation);
            this.Controls.Add(this.btnOst);
            this.Controls.Add(this.btnSouth);
            this.Controls.Add(this.btnWest);
            this.Controls.Add(this.btnNorth);
            this.Controls.Add(this.btnUsePotion);
            this.Controls.Add(this.btnUseWeapon);
            this.Controls.Add(this.cboxPotion);
            this.Controls.Add(this.cboxWeapon);
            this.Controls.Add(this.lblSelectAction);
            this.Controls.Add(this.lblEXP);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblGold);
            this.Controls.Add(this.lblHP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "SimpleRPG";
            this.Text = "Simple RPG";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblEXP;
        private System.Windows.Forms.Label lblSelectAction;
        private System.Windows.Forms.ComboBox cboxWeapon;
        private System.Windows.Forms.ComboBox cboxPotion;
        private System.Windows.Forms.Button btnUseWeapon;
        private System.Windows.Forms.Button btnUsePotion;
        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.Button btnOst;
        private System.Windows.Forms.RichTextBox rtbLocation;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.DataGridView dgvQuestLog;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.Label lblMoveCounter;
        private System.Windows.Forms.Label lblMoveCounterValue;
    }
}

