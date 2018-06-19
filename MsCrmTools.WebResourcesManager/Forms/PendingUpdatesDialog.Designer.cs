namespace MscrmTools.WebresourcesManager.Forms
{
    partial class PendingUpdatesDialog
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
            this.gbActions = new System.Windows.Forms.GroupBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.rdbUpdatePublishAdd = new System.Windows.Forms.RadioButton();
            this.rdbUpdatePublish = new System.Windows.Forms.RadioButton();
            this.rdbUpdate = new System.Windows.Forms.RadioButton();
            this.gbPendingItems = new System.Windows.Forms.GroupBox();
            this.clbWebresources = new System.Windows.Forms.CheckedListBox();
            this.pnlListAction = new System.Windows.Forms.Panel();
            this.llInvert = new System.Windows.Forms.LinkLabel();
            this.lblSplit2 = new System.Windows.Forms.Label();
            this.llCheckNone = new System.Windows.Forms.LinkLabel();
            this.lblSplit1 = new System.Windows.Forms.Label();
            this.llCheckAll = new System.Windows.Forms.LinkLabel();
            this.gbActions.SuspendLayout();
            this.gbPendingItems.SuspendLayout();
            this.pnlListAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbActions
            // 
            this.gbActions.Controls.Add(this.btnApply);
            this.gbActions.Controls.Add(this.rdbUpdatePublishAdd);
            this.gbActions.Controls.Add(this.rdbUpdatePublish);
            this.gbActions.Controls.Add(this.rdbUpdate);
            this.gbActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbActions.Location = new System.Drawing.Point(0, 0);
            this.gbActions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbActions.Name = "gbActions";
            this.gbActions.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbActions.Size = new System.Drawing.Size(568, 221);
            this.gbActions.TabIndex = 0;
            this.gbActions.TabStop = false;
            this.gbActions.Text = "Actions";
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Enabled = false;
            this.btnApply.Location = new System.Drawing.Point(15, 157);
            this.btnApply.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(538, 42);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // rdbUpdatePublishAdd
            // 
            this.rdbUpdatePublishAdd.AutoSize = true;
            this.rdbUpdatePublishAdd.Location = new System.Drawing.Point(15, 102);
            this.rdbUpdatePublishAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbUpdatePublishAdd.Name = "rdbUpdatePublishAdd";
            this.rdbUpdatePublishAdd.Size = new System.Drawing.Size(379, 29);
            this.rdbUpdatePublishAdd.TabIndex = 2;
            this.rdbUpdatePublishAdd.Text = "Update and Publish and Add to solution";
            this.rdbUpdatePublishAdd.UseVisualStyleBackColor = true;
            // 
            // rdbUpdatePublish
            // 
            this.rdbUpdatePublish.AutoSize = true;
            this.rdbUpdatePublish.Checked = true;
            this.rdbUpdatePublish.Location = new System.Drawing.Point(15, 66);
            this.rdbUpdatePublish.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbUpdatePublish.Name = "rdbUpdatePublish";
            this.rdbUpdatePublish.Size = new System.Drawing.Size(207, 29);
            this.rdbUpdatePublish.TabIndex = 1;
            this.rdbUpdatePublish.TabStop = true;
            this.rdbUpdatePublish.Text = "Update and Publish";
            this.rdbUpdatePublish.UseVisualStyleBackColor = true;
            // 
            // rdbUpdate
            // 
            this.rdbUpdate.AutoSize = true;
            this.rdbUpdate.Location = new System.Drawing.Point(15, 30);
            this.rdbUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbUpdate.Name = "rdbUpdate";
            this.rdbUpdate.Size = new System.Drawing.Size(100, 29);
            this.rdbUpdate.TabIndex = 0;
            this.rdbUpdate.Text = "Update";
            this.rdbUpdate.UseVisualStyleBackColor = true;
            // 
            // gbPendingItems
            // 
            this.gbPendingItems.Controls.Add(this.clbWebresources);
            this.gbPendingItems.Controls.Add(this.pnlListAction);
            this.gbPendingItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPendingItems.Location = new System.Drawing.Point(0, 221);
            this.gbPendingItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPendingItems.Name = "gbPendingItems";
            this.gbPendingItems.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPendingItems.Size = new System.Drawing.Size(568, 588);
            this.gbPendingItems.TabIndex = 1;
            this.gbPendingItems.TabStop = false;
            this.gbPendingItems.Text = "Webresources";
            // 
            // clbWebresources
            // 
            this.clbWebresources.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clbWebresources.CheckOnClick = true;
            this.clbWebresources.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbWebresources.FormattingEnabled = true;
            this.clbWebresources.Location = new System.Drawing.Point(4, 55);
            this.clbWebresources.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clbWebresources.Name = "clbWebresources";
            this.clbWebresources.Size = new System.Drawing.Size(560, 529);
            this.clbWebresources.Sorted = true;
            this.clbWebresources.TabIndex = 2;
            this.clbWebresources.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbWebresources_ItemCheck);
            // 
            // pnlListAction
            // 
            this.pnlListAction.Controls.Add(this.llInvert);
            this.pnlListAction.Controls.Add(this.lblSplit2);
            this.pnlListAction.Controls.Add(this.llCheckNone);
            this.pnlListAction.Controls.Add(this.lblSplit1);
            this.pnlListAction.Controls.Add(this.llCheckAll);
            this.pnlListAction.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlListAction.Location = new System.Drawing.Point(4, 26);
            this.pnlListAction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlListAction.Name = "pnlListAction";
            this.pnlListAction.Size = new System.Drawing.Size(560, 29);
            this.pnlListAction.TabIndex = 1;
            // 
            // llInvert
            // 
            this.llInvert.AutoSize = true;
            this.llInvert.Dock = System.Windows.Forms.DockStyle.Left;
            this.llInvert.Location = new System.Drawing.Point(235, 0);
            this.llInvert.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llInvert.Name = "llInvert";
            this.llInvert.Size = new System.Drawing.Size(141, 25);
            this.llInvert.TabIndex = 4;
            this.llInvert.TabStop = true;
            this.llInvert.Text = "invert selection";
            this.llInvert.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llItemsAction_LinkClicked);
            // 
            // lblSplit2
            // 
            this.lblSplit2.AutoSize = true;
            this.lblSplit2.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSplit2.Location = new System.Drawing.Point(218, 0);
            this.lblSplit2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSplit2.Name = "lblSplit2";
            this.lblSplit2.Size = new System.Drawing.Size(17, 25);
            this.lblSplit2.TabIndex = 3;
            this.lblSplit2.Text = "|";
            // 
            // llCheckNone
            // 
            this.llCheckNone.AutoSize = true;
            this.llCheckNone.Dock = System.Windows.Forms.DockStyle.Left;
            this.llCheckNone.Location = new System.Drawing.Point(105, 0);
            this.llCheckNone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llCheckNone.Name = "llCheckNone";
            this.llCheckNone.Size = new System.Drawing.Size(113, 25);
            this.llCheckNone.TabIndex = 2;
            this.llCheckNone.TabStop = true;
            this.llCheckNone.Text = "check none";
            this.llCheckNone.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llItemsAction_LinkClicked);
            // 
            // lblSplit1
            // 
            this.lblSplit1.AutoSize = true;
            this.lblSplit1.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSplit1.Location = new System.Drawing.Point(88, 0);
            this.lblSplit1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSplit1.Name = "lblSplit1";
            this.lblSplit1.Size = new System.Drawing.Size(17, 25);
            this.lblSplit1.TabIndex = 1;
            this.lblSplit1.Text = "|";
            // 
            // llCheckAll
            // 
            this.llCheckAll.AutoSize = true;
            this.llCheckAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.llCheckAll.Location = new System.Drawing.Point(0, 0);
            this.llCheckAll.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llCheckAll.Name = "llCheckAll";
            this.llCheckAll.Size = new System.Drawing.Size(88, 25);
            this.llCheckAll.TabIndex = 0;
            this.llCheckAll.TabStop = true;
            this.llCheckAll.Text = "check all";
            this.llCheckAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llItemsAction_LinkClicked);
            // 
            // PendingUpdatesDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(568, 809);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.Controls.Add(this.gbPendingItems);
            this.Controls.Add(this.gbActions);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PendingUpdatesDialog";
            this.Text = "Pending Updates";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PendingUpdatesDialog_FormClosing);
            this.gbActions.ResumeLayout(false);
            this.gbActions.PerformLayout();
            this.gbPendingItems.ResumeLayout(false);
            this.pnlListAction.ResumeLayout(false);
            this.pnlListAction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbActions;
        private System.Windows.Forms.RadioButton rdbUpdatePublishAdd;
        private System.Windows.Forms.RadioButton rdbUpdatePublish;
        private System.Windows.Forms.RadioButton rdbUpdate;
        private System.Windows.Forms.GroupBox gbPendingItems;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.CheckedListBox clbWebresources;
        private System.Windows.Forms.Panel pnlListAction;
        private System.Windows.Forms.LinkLabel llInvert;
        private System.Windows.Forms.Label lblSplit2;
        private System.Windows.Forms.LinkLabel llCheckNone;
        private System.Windows.Forms.Label lblSplit1;
        private System.Windows.Forms.LinkLabel llCheckAll;
    }
}