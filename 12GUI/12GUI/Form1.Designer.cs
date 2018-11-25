namespace _12GUI
{
    partial class FormPizza
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
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.rbNormalCrust = new System.Windows.Forms.RadioButton();
            this.rbDeepDishCrust = new System.Windows.Forms.RadioButton();
            this.rbStuffCrust = new System.Windows.Forms.RadioButton();
            this.rbDineIn = new System.Windows.Forms.RadioButton();
            this.rbDelivery = new System.Windows.Forms.RadioButton();
            this.rbCarryOut = new System.Windows.Forms.RadioButton();
            this.gBxCrust = new System.Windows.Forms.GroupBox();
            this.gBxEatMethod = new System.Windows.Forms.GroupBox();
            this.gbxToppings = new System.Windows.Forms.GroupBox();
            this.cbxOlives = new System.Windows.Forms.CheckBox();
            this.cbxPepperoni = new System.Windows.Forms.CheckBox();
            this.cbxSausage = new System.Windows.Forms.CheckBox();
            this.cbxCheese = new System.Windows.Forms.CheckBox();
            this.cbxMushroom = new System.Windows.Forms.CheckBox();
            this.txtPizza = new System.Windows.Forms.TextBox();
            this.btOrder = new System.Windows.Forms.Button();
            this.tmrBlink = new System.Windows.Forms.Timer(this.components);
            this.mtxtPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.menuPizzaTop = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.pbxPizza = new System.Windows.Forms.PictureBox();
            this.menuCalculator = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxCanadianBacon = new System.Windows.Forms.CheckBox();
            this.cbxOnion = new System.Windows.Forms.CheckBox();
            this.cbxPIneaplle = new System.Windows.Forms.CheckBox();
            this.lbTip = new System.Windows.Forms.Label();
            this.gbBevearage = new System.Windows.Forms.GroupBox();
            this.cbxSevenUp = new System.Windows.Forms.CheckBox();
            this.cbxMtDew = new System.Windows.Forms.CheckBox();
            this.cbxDrPepper = new System.Windows.Forms.CheckBox();
            this.lbSubtotal = new System.Windows.Forms.Label();
            this.lbTax = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.gBxCrust.SuspendLayout();
            this.gBxEatMethod.SuspendLayout();
            this.gbxToppings.SuspendLayout();
            this.menuPizzaTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPizza)).BeginInit();
            this.gbBevearage.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.Location = new System.Drawing.Point(5, 21);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(94, 21);
            this.rbThinCrust.TabIndex = 0;
            this.rbThinCrust.Text = "Thin Crust";
            this.rbThinCrust.UseVisualStyleBackColor = true;
            // 
            // rbNormalCrust
            // 
            this.rbNormalCrust.AutoSize = true;
            this.rbNormalCrust.Checked = true;
            this.rbNormalCrust.Location = new System.Drawing.Point(5, 48);
            this.rbNormalCrust.Name = "rbNormalCrust";
            this.rbNormalCrust.Size = new System.Drawing.Size(96, 21);
            this.rbNormalCrust.TabIndex = 1;
            this.rbNormalCrust.TabStop = true;
            this.rbNormalCrust.Text = "Traditional";
            this.rbNormalCrust.UseVisualStyleBackColor = true;
            // 
            // rbDeepDishCrust
            // 
            this.rbDeepDishCrust.AutoSize = true;
            this.rbDeepDishCrust.Location = new System.Drawing.Point(5, 75);
            this.rbDeepDishCrust.Name = "rbDeepDishCrust";
            this.rbDeepDishCrust.Size = new System.Drawing.Size(133, 21);
            this.rbDeepDishCrust.TabIndex = 2;
            this.rbDeepDishCrust.Text = "Deep Dish (+$2)";
            this.rbDeepDishCrust.UseVisualStyleBackColor = true;
            // 
            // rbStuffCrust
            // 
            this.rbStuffCrust.AutoSize = true;
            this.rbStuffCrust.Location = new System.Drawing.Point(5, 102);
            this.rbStuffCrust.Name = "rbStuffCrust";
            this.rbStuffCrust.Size = new System.Drawing.Size(133, 21);
            this.rbStuffCrust.TabIndex = 4;
            this.rbStuffCrust.Text = "Stuff Crust (+$3)";
            this.rbStuffCrust.UseVisualStyleBackColor = true;
            // 
            // rbDineIn
            // 
            this.rbDineIn.AutoSize = true;
            this.rbDineIn.Checked = true;
            this.rbDineIn.Location = new System.Drawing.Point(6, 21);
            this.rbDineIn.Name = "rbDineIn";
            this.rbDineIn.Size = new System.Drawing.Size(73, 21);
            this.rbDineIn.TabIndex = 5;
            this.rbDineIn.TabStop = true;
            this.rbDineIn.Text = "Dine In";
            this.rbDineIn.UseVisualStyleBackColor = true;
            // 
            // rbDelivery
            // 
            this.rbDelivery.AutoSize = true;
            this.rbDelivery.Location = new System.Drawing.Point(6, 73);
            this.rbDelivery.Name = "rbDelivery";
            this.rbDelivery.Size = new System.Drawing.Size(118, 21);
            this.rbDelivery.TabIndex = 6;
            this.rbDelivery.Text = "Delivery (+$5)";
            this.rbDelivery.UseVisualStyleBackColor = true;
            this.rbDelivery.CheckedChanged += new System.EventHandler(this.rbDelivery_CheckedChanged);
            // 
            // rbCarryOut
            // 
            this.rbCarryOut.AutoSize = true;
            this.rbCarryOut.Location = new System.Drawing.Point(6, 48);
            this.rbCarryOut.Name = "rbCarryOut";
            this.rbCarryOut.Size = new System.Drawing.Size(90, 21);
            this.rbCarryOut.TabIndex = 8;
            this.rbCarryOut.Text = "Carry Out";
            this.rbCarryOut.UseVisualStyleBackColor = true;
            // 
            // gBxCrust
            // 
            this.gBxCrust.Controls.Add(this.rbThinCrust);
            this.gBxCrust.Controls.Add(this.rbNormalCrust);
            this.gBxCrust.Controls.Add(this.rbDeepDishCrust);
            this.gBxCrust.Controls.Add(this.rbStuffCrust);
            this.gBxCrust.Location = new System.Drawing.Point(12, 27);
            this.gBxCrust.Name = "gBxCrust";
            this.gBxCrust.Size = new System.Drawing.Size(138, 130);
            this.gBxCrust.TabIndex = 9;
            this.gBxCrust.TabStop = false;
            this.gBxCrust.Text = "Crust ($10)";
            // 
            // gBxEatMethod
            // 
            this.gBxEatMethod.Controls.Add(this.rbCarryOut);
            this.gBxEatMethod.Controls.Add(this.rbDineIn);
            this.gBxEatMethod.Controls.Add(this.rbDelivery);
            this.gBxEatMethod.Location = new System.Drawing.Point(305, 35);
            this.gBxEatMethod.Name = "gBxEatMethod";
            this.gBxEatMethod.Size = new System.Drawing.Size(139, 130);
            this.gBxEatMethod.TabIndex = 10;
            this.gBxEatMethod.TabStop = false;
            this.gBxEatMethod.Text = "Eating Option";
            // 
            // gbxToppings
            // 
            this.gbxToppings.Controls.Add(this.cbxCanadianBacon);
            this.gbxToppings.Controls.Add(this.cbxOnion);
            this.gbxToppings.Controls.Add(this.cbxPIneaplle);
            this.gbxToppings.Controls.Add(this.cbxOlives);
            this.gbxToppings.Controls.Add(this.cbxPepperoni);
            this.gbxToppings.Controls.Add(this.cbxSausage);
            this.gbxToppings.Controls.Add(this.cbxCheese);
            this.gbxToppings.Controls.Add(this.cbxMushroom);
            this.gbxToppings.Location = new System.Drawing.Point(156, 31);
            this.gbxToppings.Name = "gbxToppings";
            this.gbxToppings.Size = new System.Drawing.Size(143, 235);
            this.gbxToppings.TabIndex = 11;
            this.gbxToppings.TabStop = false;
            this.gbxToppings.Text = "Toppings (+50¢)";
            // 
            // cbxOlives
            // 
            this.cbxOlives.AutoSize = true;
            this.cbxOlives.Location = new System.Drawing.Point(7, 127);
            this.cbxOlives.Name = "cbxOlives";
            this.cbxOlives.Size = new System.Drawing.Size(69, 21);
            this.cbxOlives.TabIndex = 4;
            this.cbxOlives.Text = "Olives";
            this.cbxOlives.UseVisualStyleBackColor = true;
            // 
            // cbxPepperoni
            // 
            this.cbxPepperoni.AutoSize = true;
            this.cbxPepperoni.Location = new System.Drawing.Point(7, 73);
            this.cbxPepperoni.Name = "cbxPepperoni";
            this.cbxPepperoni.Size = new System.Drawing.Size(95, 21);
            this.cbxPepperoni.TabIndex = 2;
            this.cbxPepperoni.Text = "Pepperoni";
            this.cbxPepperoni.UseVisualStyleBackColor = true;
            // 
            // cbxSausage
            // 
            this.cbxSausage.AutoSize = true;
            this.cbxSausage.Location = new System.Drawing.Point(7, 47);
            this.cbxSausage.Name = "cbxSausage";
            this.cbxSausage.Size = new System.Drawing.Size(86, 21);
            this.cbxSausage.TabIndex = 1;
            this.cbxSausage.Text = "Sausage";
            this.cbxSausage.UseVisualStyleBackColor = true;
            // 
            // cbxCheese
            // 
            this.cbxCheese.AutoSize = true;
            this.cbxCheese.Location = new System.Drawing.Point(7, 22);
            this.cbxCheese.Name = "cbxCheese";
            this.cbxCheese.Size = new System.Drawing.Size(114, 21);
            this.cbxCheese.TabIndex = 0;
            this.cbxCheese.Text = "Extra Cheese";
            this.cbxCheese.UseVisualStyleBackColor = true;
            // 
            // cbxMushroom
            // 
            this.cbxMushroom.AutoSize = true;
            this.cbxMushroom.Location = new System.Drawing.Point(7, 100);
            this.cbxMushroom.Name = "cbxMushroom";
            this.cbxMushroom.Size = new System.Drawing.Size(96, 21);
            this.cbxMushroom.TabIndex = 3;
            this.cbxMushroom.Text = "Mushroom";
            this.cbxMushroom.UseVisualStyleBackColor = true;
            // 
            // txtPizza
            // 
            this.txtPizza.Location = new System.Drawing.Point(450, 31);
            this.txtPizza.Multiline = true;
            this.txtPizza.Name = "txtPizza";
            this.txtPizza.ReadOnly = true;
            this.txtPizza.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPizza.Size = new System.Drawing.Size(244, 229);
            this.txtPizza.TabIndex = 12;
            this.txtPizza.TabStop = false;
            // 
            // btOrder
            // 
            this.btOrder.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btOrder.Location = new System.Drawing.Point(156, 266);
            this.btOrder.Name = "btOrder";
            this.btOrder.Size = new System.Drawing.Size(139, 66);
            this.btOrder.TabIndex = 13;
            this.btOrder.Text = "Order";
            this.btOrder.UseVisualStyleBackColor = false;
            this.btOrder.Click += new System.EventHandler(this.btOrder_Click);
            // 
            // tmrBlink
            // 
            this.tmrBlink.Enabled = true;
            this.tmrBlink.Interval = 1000;
            this.tmrBlink.Tick += new System.EventHandler(this.tmrBlink_Tick);
            // 
            // mtxtPhoneNumber
            // 
            this.mtxtPhoneNumber.BeepOnError = true;
            this.mtxtPhoneNumber.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxtPhoneNumber.Location = new System.Drawing.Point(15, 300);
            this.mtxtPhoneNumber.Mask = "(999) 000-0000";
            this.mtxtPhoneNumber.Name = "mtxtPhoneNumber";
            this.mtxtPhoneNumber.Size = new System.Drawing.Size(124, 22);
            this.mtxtPhoneNumber.TabIndex = 15;
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.Location = new System.Drawing.Point(18, 280);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(107, 17);
            this.lbPhoneNumber.TabIndex = 16;
            this.lbPhoneNumber.Text = "Phone Number:";
            // 
            // menuPizzaTop
            // 
            this.menuPizzaTop.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuPizzaTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuCalculator,
            this.menuHelp});
            this.menuPizzaTop.Location = new System.Drawing.Point(0, 0);
            this.menuPizzaTop.Name = "menuPizzaTop";
            this.menuPizzaTop.Size = new System.Drawing.Size(701, 28);
            this.menuPizzaTop.TabIndex = 17;
            this.menuPizzaTop.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(44, 24);
            this.menuFile.Text = "&File";
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Space)));
            this.menuFileExit.Size = new System.Drawing.Size(216, 26);
            this.menuFileExit.Text = "E&xit";
            this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(53, 24);
            this.menuHelp.Text = "&Help";
            this.menuHelp.Click += new System.EventHandler(this.menuHelp_Click);
            // 
            // pbxPizza
            // 
            this.pbxPizza.Image = global::_12GUI.Properties.Resources.pizza;
            this.pbxPizza.Location = new System.Drawing.Point(311, 219);
            this.pbxPizza.Name = "pbxPizza";
            this.pbxPizza.Size = new System.Drawing.Size(138, 124);
            this.pbxPizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPizza.TabIndex = 14;
            this.pbxPizza.TabStop = false;
            // 
            // menuCalculator
            // 
            this.menuCalculator.Name = "menuCalculator";
            this.menuCalculator.Size = new System.Drawing.Size(88, 24);
            this.menuCalculator.Text = "Calculator";
            this.menuCalculator.Click += new System.EventHandler(this.calculatorToolStripMenuItem_Click);
            // 
            // cbxCanadianBacon
            // 
            this.cbxCanadianBacon.AutoSize = true;
            this.cbxCanadianBacon.Location = new System.Drawing.Point(6, 208);
            this.cbxCanadianBacon.Name = "cbxCanadianBacon";
            this.cbxCanadianBacon.Size = new System.Drawing.Size(134, 21);
            this.cbxCanadianBacon.TabIndex = 7;
            this.cbxCanadianBacon.Text = "Canadian Bacon";
            this.cbxCanadianBacon.UseVisualStyleBackColor = true;
            // 
            // cbxOnion
            // 
            this.cbxOnion.AutoSize = true;
            this.cbxOnion.Location = new System.Drawing.Point(6, 154);
            this.cbxOnion.Name = "cbxOnion";
            this.cbxOnion.Size = new System.Drawing.Size(68, 21);
            this.cbxOnion.TabIndex = 5;
            this.cbxOnion.Text = "Onion";
            this.cbxOnion.UseVisualStyleBackColor = true;
            // 
            // cbxPIneaplle
            // 
            this.cbxPIneaplle.AutoSize = true;
            this.cbxPIneaplle.Location = new System.Drawing.Point(6, 181);
            this.cbxPIneaplle.Name = "cbxPIneaplle";
            this.cbxPIneaplle.Size = new System.Drawing.Size(93, 21);
            this.cbxPIneaplle.TabIndex = 6;
            this.cbxPIneaplle.Text = "Pineapple";
            this.cbxPIneaplle.UseVisualStyleBackColor = true;
            // 
            // lbTip
            // 
            this.lbTip.AutoSize = true;
            this.lbTip.Location = new System.Drawing.Point(308, 171);
            this.lbTip.Name = "lbTip";
            this.lbTip.Size = new System.Drawing.Size(89, 17);
            this.lbTip.TabIndex = 18;
            this.lbTip.Text = "Optional Tip:";
            // 
            // gbBevearage
            // 
            this.gbBevearage.Controls.Add(this.cbxSevenUp);
            this.gbBevearage.Controls.Add(this.cbxMtDew);
            this.gbBevearage.Controls.Add(this.cbxDrPepper);
            this.gbBevearage.Location = new System.Drawing.Point(14, 163);
            this.gbBevearage.Name = "gbBevearage";
            this.gbBevearage.Size = new System.Drawing.Size(136, 114);
            this.gbBevearage.TabIndex = 12;
            this.gbBevearage.TabStop = false;
            this.gbBevearage.Text = "Beverage ($2)";
            // 
            // cbxSevenUp
            // 
            this.cbxSevenUp.AutoSize = true;
            this.cbxSevenUp.Location = new System.Drawing.Point(7, 73);
            this.cbxSevenUp.Name = "cbxSevenUp";
            this.cbxSevenUp.Size = new System.Drawing.Size(60, 21);
            this.cbxSevenUp.TabIndex = 2;
            this.cbxSevenUp.Text = "7 Up";
            this.cbxSevenUp.UseVisualStyleBackColor = true;
            // 
            // cbxMtDew
            // 
            this.cbxMtDew.AutoSize = true;
            this.cbxMtDew.Location = new System.Drawing.Point(7, 47);
            this.cbxMtDew.Name = "cbxMtDew";
            this.cbxMtDew.Size = new System.Drawing.Size(119, 21);
            this.cbxMtDew.TabIndex = 1;
            this.cbxMtDew.Text = "Mountain Dew";
            this.cbxMtDew.UseVisualStyleBackColor = true;
            // 
            // cbxDrPepper
            // 
            this.cbxDrPepper.AutoSize = true;
            this.cbxDrPepper.Location = new System.Drawing.Point(7, 22);
            this.cbxDrPepper.Name = "cbxDrPepper";
            this.cbxDrPepper.Size = new System.Drawing.Size(95, 21);
            this.cbxDrPepper.TabIndex = 0;
            this.cbxDrPepper.Text = "Dr Pepper";
            this.cbxDrPepper.UseVisualStyleBackColor = true;
            // 
            // lbSubtotal
            // 
            this.lbSubtotal.AutoSize = true;
            this.lbSubtotal.Location = new System.Drawing.Point(455, 266);
            this.lbSubtotal.Name = "lbSubtotal";
            this.lbSubtotal.Size = new System.Drawing.Size(64, 17);
            this.lbSubtotal.TabIndex = 20;
            this.lbSubtotal.Text = "Subtotal:";
            // 
            // lbTax
            // 
            this.lbTax.AutoSize = true;
            this.lbTax.Location = new System.Drawing.Point(455, 289);
            this.lbTax.Name = "lbTax";
            this.lbTax.Size = new System.Drawing.Size(35, 17);
            this.lbTax.TabIndex = 21;
            this.lbTax.Text = "Tax:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.BackColor = System.Drawing.SystemColors.Control;
            this.txtSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(521, 263);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(148, 15);
            this.txtSubtotal.TabIndex = 22;
            this.txtSubtotal.TabStop = false;
            // 
            // txtTax
            // 
            this.txtTax.BackColor = System.Drawing.SystemColors.Control;
            this.txtTax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTax.Enabled = false;
            this.txtTax.Location = new System.Drawing.Point(521, 286);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(148, 15);
            this.txtTax.TabIndex = 23;
            this.txtTax.TabStop = false;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(521, 307);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(148, 15);
            this.txtTotal.TabIndex = 25;
            this.txtTotal.TabStop = false;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(455, 310);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(44, 17);
            this.lbTotal.TabIndex = 24;
            this.lbTotal.Text = "Total:";
            // 
            // txtTip
            // 
            this.txtTip.Location = new System.Drawing.Point(305, 191);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(139, 22);
            this.txtTip.TabIndex = 19;
            // 
            // FormPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(701, 346);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.lbTax);
            this.Controls.Add(this.lbSubtotal);
            this.Controls.Add(this.gbBevearage);
            this.Controls.Add(this.txtTip);
            this.Controls.Add(this.lbTip);
            this.Controls.Add(this.lbPhoneNumber);
            this.Controls.Add(this.mtxtPhoneNumber);
            this.Controls.Add(this.pbxPizza);
            this.Controls.Add(this.btOrder);
            this.Controls.Add(this.txtPizza);
            this.Controls.Add(this.gbxToppings);
            this.Controls.Add(this.gBxEatMethod);
            this.Controls.Add(this.gBxCrust);
            this.Controls.Add(this.menuPizzaTop);
            this.MainMenuStrip = this.menuPizzaTop;
            this.Name = "FormPizza";
            this.Text = "GUI Pizza";
            this.gBxCrust.ResumeLayout(false);
            this.gBxCrust.PerformLayout();
            this.gBxEatMethod.ResumeLayout(false);
            this.gBxEatMethod.PerformLayout();
            this.gbxToppings.ResumeLayout(false);
            this.gbxToppings.PerformLayout();
            this.menuPizzaTop.ResumeLayout(false);
            this.menuPizzaTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPizza)).EndInit();
            this.gbBevearage.ResumeLayout(false);
            this.gbBevearage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.RadioButton rbNormalCrust;
        private System.Windows.Forms.RadioButton rbDeepDishCrust;
        private System.Windows.Forms.RadioButton rbStuffCrust;
        private System.Windows.Forms.RadioButton rbDineIn;
        private System.Windows.Forms.RadioButton rbDelivery;
        private System.Windows.Forms.RadioButton rbCarryOut;
        private System.Windows.Forms.GroupBox gBxCrust;
        private System.Windows.Forms.GroupBox gBxEatMethod;
        private System.Windows.Forms.GroupBox gbxToppings;
        private System.Windows.Forms.CheckBox cbxCheese;
        private System.Windows.Forms.CheckBox cbxOlives;
        private System.Windows.Forms.CheckBox cbxPepperoni;
        private System.Windows.Forms.CheckBox cbxSausage;
        private System.Windows.Forms.CheckBox cbxMushroom;
        private System.Windows.Forms.TextBox txtPizza;
        private System.Windows.Forms.Button btOrder;
        private System.Windows.Forms.PictureBox pbxPizza;
        private System.Windows.Forms.Timer tmrBlink;
        private System.Windows.Forms.MaskedTextBox mtxtPhoneNumber;
        private System.Windows.Forms.Label lbPhoneNumber;
        private System.Windows.Forms.MenuStrip menuPizzaTop;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuCalculator;
        private System.Windows.Forms.CheckBox cbxCanadianBacon;
        private System.Windows.Forms.CheckBox cbxOnion;
        private System.Windows.Forms.CheckBox cbxPIneaplle;
        private System.Windows.Forms.Label lbTip;
        private System.Windows.Forms.GroupBox gbBevearage;
        private System.Windows.Forms.CheckBox cbxSevenUp;
        private System.Windows.Forms.CheckBox cbxMtDew;
        private System.Windows.Forms.CheckBox cbxDrPepper;
        private System.Windows.Forms.Label lbSubtotal;
        private System.Windows.Forms.Label lbTax;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.TextBox txtTip;
    }
}

