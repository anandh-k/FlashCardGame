
namespace FlashCardGame
{
    partial class FlashCard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.homePanel = new System.Windows.Forms.Panel();
            this.division = new System.Windows.Forms.RadioButton();
            this.multiply = new System.Windows.Forms.RadioButton();
            this.subtraction = new System.Windows.Forms.RadioButton();
            this.addition = new System.Windows.Forms.RadioButton();
            this.userName = new System.Windows.Forms.TextBox();
            this.exitApp = new System.Windows.Forms.Button();
            this.startGame = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.gamePointsLabel = new System.Windows.Forms.Label();
            this.gameTimerLabel = new System.Windows.Forms.Label();
            this.abortGame = new System.Windows.Forms.Button();
            this.answerStatus = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.userInput = new System.Windows.Forms.TextBox();
            this.operation = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.homePanel.SuspendLayout();
            this.gamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // homePanel
            // 
            this.homePanel.Controls.Add(this.division);
            this.homePanel.Controls.Add(this.multiply);
            this.homePanel.Controls.Add(this.subtraction);
            this.homePanel.Controls.Add(this.addition);
            this.homePanel.Controls.Add(this.userName);
            this.homePanel.Controls.Add(this.exitApp);
            this.homePanel.Controls.Add(this.startGame);
            this.homePanel.Controls.Add(this.label2);
            this.homePanel.Controls.Add(this.label1);
            this.homePanel.Location = new System.Drawing.Point(66, 54);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(513, 375);
            this.homePanel.TabIndex = 0;
            // 
            // division
            // 
            this.division.AutoSize = true;
            this.division.Location = new System.Drawing.Point(226, 196);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(100, 29);
            this.division.TabIndex = 8;
            this.division.TabStop = true;
            this.division.Text = "Division";
            this.division.UseVisualStyleBackColor = true;
            // 
            // multiply
            // 
            this.multiply.AutoSize = true;
            this.multiply.Location = new System.Drawing.Point(226, 154);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(144, 29);
            this.multiply.TabIndex = 7;
            this.multiply.TabStop = true;
            this.multiply.Text = "Multiplication";
            this.multiply.UseVisualStyleBackColor = true;
            // 
            // subtraction
            // 
            this.subtraction.AutoSize = true;
            this.subtraction.Location = new System.Drawing.Point(226, 116);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(128, 29);
            this.subtraction.TabIndex = 6;
            this.subtraction.TabStop = true;
            this.subtraction.Text = "Subtraction";
            this.subtraction.UseVisualStyleBackColor = true;
            // 
            // addition
            // 
            this.addition.AutoSize = true;
            this.addition.Location = new System.Drawing.Point(226, 79);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(106, 29);
            this.addition.TabIndex = 5;
            this.addition.TabStop = true;
            this.addition.Text = "Addition";
            this.addition.UseVisualStyleBackColor = true;
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(226, 29);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(150, 31);
            this.userName.TabIndex = 4;
            // 
            // exitApp
            // 
            this.exitApp.Location = new System.Drawing.Point(264, 294);
            this.exitApp.Name = "exitApp";
            this.exitApp.Size = new System.Drawing.Size(112, 34);
            this.exitApp.TabIndex = 3;
            this.exitApp.Text = "Exit";
            this.exitApp.UseVisualStyleBackColor = true;
            this.exitApp.Click += new System.EventHandler(this.exitApp_Click);
            // 
            // startGame
            // 
            this.startGame.Location = new System.Drawing.Point(81, 294);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(154, 34);
            this.startGame.TabIndex = 2;
            this.startGame.Text = "Start playing";
            this.startGame.UseVisualStyleBackColor = true;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose operation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // gamePanel
            // 
            this.gamePanel.Controls.Add(this.label3);
            this.gamePanel.Controls.Add(this.gamePointsLabel);
            this.gamePanel.Controls.Add(this.gameTimerLabel);
            this.gamePanel.Controls.Add(this.abortGame);
            this.gamePanel.Controls.Add(this.answerStatus);
            this.gamePanel.Controls.Add(this.submit);
            this.gamePanel.Controls.Add(this.userInput);
            this.gamePanel.Controls.Add(this.operation);
            this.gamePanel.Location = new System.Drawing.Point(76, 484);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(990, 309);
            this.gamePanel.TabIndex = 1;
            this.gamePanel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(695, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Your score";
            // 
            // gamePointsLabel
            // 
            this.gamePointsLabel.AutoSize = true;
            this.gamePointsLabel.Location = new System.Drawing.Point(695, 186);
            this.gamePointsLabel.Name = "gamePointsLabel";
            this.gamePointsLabel.Size = new System.Drawing.Size(22, 25);
            this.gamePointsLabel.TabIndex = 8;
            this.gamePointsLabel.Text = "0";
            // 
            // gameTimerLabel
            // 
            this.gameTimerLabel.AutoSize = true;
            this.gameTimerLabel.Location = new System.Drawing.Point(695, 100);
            this.gameTimerLabel.Name = "gameTimerLabel";
            this.gameTimerLabel.Size = new System.Drawing.Size(100, 25);
            this.gameTimerLabel.TabIndex = 7;
            this.gameTimerLabel.Text = "60 secs left";
            // 
            // abortGame
            // 
            this.abortGame.Location = new System.Drawing.Point(232, 209);
            this.abortGame.Name = "abortGame";
            this.abortGame.Size = new System.Drawing.Size(112, 34);
            this.abortGame.TabIndex = 6;
            this.abortGame.Text = "Abort";
            this.abortGame.UseVisualStyleBackColor = true;
            this.abortGame.Click += new System.EventHandler(this.abortGame_Click);
            // 
            // answerStatus
            // 
            this.answerStatus.AutoSize = true;
            this.answerStatus.Location = new System.Drawing.Point(74, 100);
            this.answerStatus.Name = "answerStatus";
            this.answerStatus.Size = new System.Drawing.Size(122, 25);
            this.answerStatus.TabIndex = 5;
            this.answerStatus.Text = "Answer status";
            this.answerStatus.Visible = false;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(401, 35);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(112, 34);
            this.submit.TabIndex = 4;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // userInput
            // 
            this.userInput.Location = new System.Drawing.Point(216, 37);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(150, 31);
            this.userInput.TabIndex = 3;
            // 
            // operation
            // 
            this.operation.AutoSize = true;
            this.operation.Location = new System.Drawing.Point(71, 43);
            this.operation.Name = "operation";
            this.operation.Size = new System.Drawing.Size(84, 25);
            this.operation.TabIndex = 2;
            this.operation.Text = "Question";
            // 
            // FlashCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 965);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.homePanel);
            this.Name = "FlashCard";
            this.Text = "Form1";
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.RadioButton division;
        private System.Windows.Forms.RadioButton multiply;
        private System.Windows.Forms.RadioButton subtraction;
        private System.Windows.Forms.RadioButton addition;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Button exitApp;
        private System.Windows.Forms.Button startGame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.Label operation;
        private System.Windows.Forms.Label answerStatus;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button abortGame;
        private System.Windows.Forms.Label gamePointsLabel;
        private System.Windows.Forms.Label gameTimerLabel;
        private System.Windows.Forms.Label label3;
    }
}

