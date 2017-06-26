namespace MainMenu
{
    partial class frmMainMenu
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cakesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardCakesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vanillaCakeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chocolateCakeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackForestCakeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteForestCakeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheeseCakesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oreaCheeseCakeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strawberryCheeseCakeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toppingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.macaroonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fruitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nutsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chocolateFlakesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveryOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pickUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDisplayOptions = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foreColourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backColourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblDeliveryOption = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cakesToolStripMenuItem,
            this.toppingsToolStripMenuItem,
            this.deliveryOptionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(856, 49);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cakesToolStripMenuItem
            // 
            this.cakesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardCakesToolStripMenuItem,
            this.cheeseCakesToolStripMenuItem});
            this.cakesToolStripMenuItem.Name = "cakesToolStripMenuItem";
            this.cakesToolStripMenuItem.Size = new System.Drawing.Size(108, 45);
            this.cakesToolStripMenuItem.Text = "Cakes";
            // 
            // standardCakesToolStripMenuItem
            // 
            this.standardCakesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vanillaCakeToolStripMenuItem,
            this.chocolateCakeToolStripMenuItem,
            this.blackForestCakeToolStripMenuItem,
            this.whiteForestCakeToolStripMenuItem});
            this.standardCakesToolStripMenuItem.Name = "standardCakesToolStripMenuItem";
            this.standardCakesToolStripMenuItem.Size = new System.Drawing.Size(337, 46);
            this.standardCakesToolStripMenuItem.Text = "Standard Cakes";
            // 
            // vanillaCakeToolStripMenuItem
            // 
            this.vanillaCakeToolStripMenuItem.Name = "vanillaCakeToolStripMenuItem";
            this.vanillaCakeToolStripMenuItem.Size = new System.Drawing.Size(374, 46);
            this.vanillaCakeToolStripMenuItem.Text = "Vanilla Cake";
            this.vanillaCakeToolStripMenuItem.Click += new System.EventHandler(this.vanillaCakeToolStripMenuItem_Click);
            // 
            // chocolateCakeToolStripMenuItem
            // 
            this.chocolateCakeToolStripMenuItem.Name = "chocolateCakeToolStripMenuItem";
            this.chocolateCakeToolStripMenuItem.Size = new System.Drawing.Size(374, 46);
            this.chocolateCakeToolStripMenuItem.Text = "Chocolate Cake";
            // 
            // blackForestCakeToolStripMenuItem
            // 
            this.blackForestCakeToolStripMenuItem.Name = "blackForestCakeToolStripMenuItem";
            this.blackForestCakeToolStripMenuItem.Size = new System.Drawing.Size(374, 46);
            this.blackForestCakeToolStripMenuItem.Text = "Black Forest Cake";
            // 
            // whiteForestCakeToolStripMenuItem
            // 
            this.whiteForestCakeToolStripMenuItem.Name = "whiteForestCakeToolStripMenuItem";
            this.whiteForestCakeToolStripMenuItem.Size = new System.Drawing.Size(374, 46);
            this.whiteForestCakeToolStripMenuItem.Text = "White Forest Cake";
            // 
            // cheeseCakesToolStripMenuItem
            // 
            this.cheeseCakesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oreaCheeseCakeToolStripMenuItem,
            this.strawberryCheeseCakeToolStripMenuItem});
            this.cheeseCakesToolStripMenuItem.Name = "cheeseCakesToolStripMenuItem";
            this.cheeseCakesToolStripMenuItem.Size = new System.Drawing.Size(337, 46);
            this.cheeseCakesToolStripMenuItem.Text = "Cheesecakes";
            // 
            // oreaCheeseCakeToolStripMenuItem
            // 
            this.oreaCheeseCakeToolStripMenuItem.Name = "oreaCheeseCakeToolStripMenuItem";
            this.oreaCheeseCakeToolStripMenuItem.Size = new System.Drawing.Size(439, 46);
            this.oreaCheeseCakeToolStripMenuItem.Text = "Orea Cheesecake";
            // 
            // strawberryCheeseCakeToolStripMenuItem
            // 
            this.strawberryCheeseCakeToolStripMenuItem.Name = "strawberryCheeseCakeToolStripMenuItem";
            this.strawberryCheeseCakeToolStripMenuItem.Size = new System.Drawing.Size(439, 46);
            this.strawberryCheeseCakeToolStripMenuItem.Text = "Strawberry Cheesecake";
            // 
            // toppingsToolStripMenuItem
            // 
            this.toppingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.macaroonsToolStripMenuItem,
            this.fruitsToolStripMenuItem,
            this.nutsToolStripMenuItem,
            this.chocolateFlakesToolStripMenuItem});
            this.toppingsToolStripMenuItem.Name = "toppingsToolStripMenuItem";
            this.toppingsToolStripMenuItem.Size = new System.Drawing.Size(152, 45);
            this.toppingsToolStripMenuItem.Text = "Toppings";
            // 
            // macaroonsToolStripMenuItem
            // 
            this.macaroonsToolStripMenuItem.Name = "macaroonsToolStripMenuItem";
            this.macaroonsToolStripMenuItem.Size = new System.Drawing.Size(356, 46);
            this.macaroonsToolStripMenuItem.Text = "Macaroons";
            this.macaroonsToolStripMenuItem.Click += new System.EventHandler(this.macaroonsToolStripMenuItem_Click);
            // 
            // fruitsToolStripMenuItem
            // 
            this.fruitsToolStripMenuItem.Name = "fruitsToolStripMenuItem";
            this.fruitsToolStripMenuItem.Size = new System.Drawing.Size(356, 46);
            this.fruitsToolStripMenuItem.Text = "Fruits";
            // 
            // nutsToolStripMenuItem
            // 
            this.nutsToolStripMenuItem.Name = "nutsToolStripMenuItem";
            this.nutsToolStripMenuItem.Size = new System.Drawing.Size(356, 46);
            this.nutsToolStripMenuItem.Text = "Nuts";
            // 
            // chocolateFlakesToolStripMenuItem
            // 
            this.chocolateFlakesToolStripMenuItem.Name = "chocolateFlakesToolStripMenuItem";
            this.chocolateFlakesToolStripMenuItem.Size = new System.Drawing.Size(356, 46);
            this.chocolateFlakesToolStripMenuItem.Text = "Chocolate Flakes";
            // 
            // deliveryOptionsToolStripMenuItem
            // 
            this.deliveryOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pickUpToolStripMenuItem,
            this.deliveryToolStripMenuItem});
            this.deliveryOptionsToolStripMenuItem.Name = "deliveryOptionsToolStripMenuItem";
            this.deliveryOptionsToolStripMenuItem.Size = new System.Drawing.Size(250, 45);
            this.deliveryOptionsToolStripMenuItem.Text = "Delivery Options";
            // 
            // pickUpToolStripMenuItem
            // 
            this.pickUpToolStripMenuItem.Name = "pickUpToolStripMenuItem";
            this.pickUpToolStripMenuItem.Size = new System.Drawing.Size(239, 46);
            this.pickUpToolStripMenuItem.Text = "Pick-Up";
            this.pickUpToolStripMenuItem.Click += new System.EventHandler(this.pickUpToolStripMenuItem_Click);
            // 
            // deliveryToolStripMenuItem
            // 
            this.deliveryToolStripMenuItem.Name = "deliveryToolStripMenuItem";
            this.deliveryToolStripMenuItem.Size = new System.Drawing.Size(239, 46);
            this.deliveryToolStripMenuItem.Text = "Delivery";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(112, 45);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lblDisplayOptions
            // 
            this.lblDisplayOptions.AutoSize = true;
            this.lblDisplayOptions.ContextMenuStrip = this.contextMenuStrip1;
            this.lblDisplayOptions.Location = new System.Drawing.Point(94, 359);
            this.lblDisplayOptions.Name = "lblDisplayOptions";
            this.lblDisplayOptions.Size = new System.Drawing.Size(241, 32);
            this.lblDisplayOptions.TabIndex = 1;
            this.lblDisplayOptions.Text = "Customer Choice:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.colourToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(328, 151);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(327, 46);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colourToolStripMenuItem
            // 
            this.colourToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.foreColourToolStripMenuItem,
            this.backColourToolStripMenuItem});
            this.colourToolStripMenuItem.Name = "colourToolStripMenuItem";
            this.colourToolStripMenuItem.Size = new System.Drawing.Size(327, 46);
            this.colourToolStripMenuItem.Text = "Colour";
            // 
            // foreColourToolStripMenuItem
            // 
            this.foreColourToolStripMenuItem.Name = "foreColourToolStripMenuItem";
            this.foreColourToolStripMenuItem.Size = new System.Drawing.Size(327, 46);
            this.foreColourToolStripMenuItem.Text = "Fore Colour";
            this.foreColourToolStripMenuItem.Click += new System.EventHandler(this.foreColourToolStripMenuItem_Click);
            // 
            // backColourToolStripMenuItem
            // 
            this.backColourToolStripMenuItem.Name = "backColourToolStripMenuItem";
            this.backColourToolStripMenuItem.Size = new System.Drawing.Size(327, 46);
            this.backColourToolStripMenuItem.Text = "Back Colour";
            this.backColourToolStripMenuItem.Click += new System.EventHandler(this.backColourToolStripMenuItem_Click);
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Location = new System.Drawing.Point(94, 420);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(141, 32);
            this.lblToppings.TabIndex = 2;
            this.lblToppings.Text = "Toppings:";
            // 
            // lblDeliveryOption
            // 
            this.lblDeliveryOption.AutoSize = true;
            this.lblDeliveryOption.Location = new System.Drawing.Point(94, 481);
            this.lblDeliveryOption.Name = "lblDeliveryOption";
            this.lblDeliveryOption.Size = new System.Drawing.Size(218, 32);
            this.lblDeliveryOption.TabIndex = 3;
            this.lblDeliveryOption.Text = "Delivery Option:";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 877);
            this.Controls.Add(this.lblDeliveryOption);
            this.Controls.Add(this.lblToppings);
            this.Controls.Add(this.lblDisplayOptions);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainMenu";
            this.Text = "MainMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cakesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standardCakesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vanillaCakeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chocolateCakeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackForestCakeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiteForestCakeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheeseCakesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oreaCheeseCakeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strawberryCheeseCakeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toppingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem macaroonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fruitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nutsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chocolateFlakesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveryOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pickUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lblDisplayOptions;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblDeliveryOption;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foreColourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backColourToolStripMenuItem;
    }
}

