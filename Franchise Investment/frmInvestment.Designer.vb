<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInvestment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDisplay = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lstFranchise = New System.Windows.Forms.ListBox()
        Me.lblFranchise = New System.Windows.Forms.Label()
        Me.lblSelectedInvestment = New System.Windows.Forms.Label()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.picFranchise = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picFranchise, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(686, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDisplay, Me.mnuClear, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuDisplay
        '
        Me.mnuDisplay.Name = "mnuDisplay"
        Me.mnuDisplay.Size = New System.Drawing.Size(333, 22)
        Me.mnuDisplay.Text = "Display Restaurant Names and Investment Values"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(333, 22)
        Me.mnuClear.Text = "&Clear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(333, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.LightSlateGray
        Me.lblTitle.Location = New System.Drawing.Point(168, 24)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(322, 36)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Franchise Investment"
        '
        'lstFranchise
        '
        Me.lstFranchise.ForeColor = System.Drawing.Color.LightSlateGray
        Me.lstFranchise.FormattingEnabled = True
        Me.lstFranchise.Location = New System.Drawing.Point(373, 87)
        Me.lstFranchise.Name = "lstFranchise"
        Me.lstFranchise.Size = New System.Drawing.Size(228, 173)
        Me.lstFranchise.TabIndex = 3
        '
        'lblFranchise
        '
        Me.lblFranchise.AutoSize = True
        Me.lblFranchise.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFranchise.ForeColor = System.Drawing.Color.LightSlateGray
        Me.lblFranchise.Location = New System.Drawing.Point(369, 63)
        Me.lblFranchise.Name = "lblFranchise"
        Me.lblFranchise.Size = New System.Drawing.Size(156, 24)
        Me.lblFranchise.TabIndex = 4
        Me.lblFranchise.Text = "Select Franchise:"
        '
        'lblSelectedInvestment
        '
        Me.lblSelectedInvestment.AutoSize = True
        Me.lblSelectedInvestment.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedInvestment.Location = New System.Drawing.Point(197, 290)
        Me.lblSelectedInvestment.Name = "lblSelectedInvestment"
        Me.lblSelectedInvestment.Size = New System.Drawing.Size(292, 25)
        Me.lblSelectedInvestment.TabIndex = 5
        Me.lblSelectedInvestment.Text = "XXXXXXXXXXXXXXXXXXXX"
        Me.lblSelectedInvestment.Visible = False
        '
        'btnCompute
        '
        Me.btnCompute.BackColor = System.Drawing.Color.SlateGray
        Me.btnCompute.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.ForeColor = System.Drawing.Color.White
        Me.btnCompute.Location = New System.Drawing.Point(192, 327)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(297, 39)
        Me.btnCompute.TabIndex = 6
        Me.btnCompute.Text = "Compute Average Investment"
        Me.btnCompute.UseVisualStyleBackColor = False
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(197, 382)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(292, 25)
        Me.lblCost.TabIndex = 7
        Me.lblCost.Text = "XXXXXXXXXXXXXXXXXXXX"
        Me.lblCost.Visible = False
        '
        'picFranchise
        '
        Me.picFranchise.Image = Global.Franchise_Investment.My.Resources.Resources.Franchise
        Me.picFranchise.Location = New System.Drawing.Point(75, 66)
        Me.picFranchise.Name = "picFranchise"
        Me.picFranchise.Size = New System.Drawing.Size(250, 194)
        Me.picFranchise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFranchise.TabIndex = 2
        Me.picFranchise.TabStop = False
        '
        'frmInvestment
        '
        Me.AcceptButton = Me.btnCompute
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(686, 425)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.lblSelectedInvestment)
        Me.Controls.Add(Me.lblFranchise)
        Me.Controls.Add(Me.lstFranchise)
        Me.Controls.Add(Me.picFranchise)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmInvestment"
        Me.Text = "Franchise Investment"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picFranchise, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuDisplay As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents lblTitle As Label
    Friend WithEvents picFranchise As PictureBox
    Friend WithEvents lstFranchise As ListBox
    Friend WithEvents lblFranchise As Label
    Friend WithEvents lblSelectedInvestment As Label
    Friend WithEvents btnCompute As Button
    Friend WithEvents lblCost As Label
End Class
