<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisplay
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.picFranchise2 = New System.Windows.Forms.PictureBox()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.picFranchise2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.SlateGray
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.ForeColor = System.Drawing.Color.White
        Me.btnReturn.Location = New System.Drawing.Point(169, 319)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(230, 47)
        Me.btnReturn.TabIndex = 0
        Me.btnReturn.Text = "Return to Application"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'picFranchise2
        '
        Me.picFranchise2.Image = Global.Franchise_Investment.My.Resources.Resources.Franchise
        Me.picFranchise2.Location = New System.Drawing.Point(0, 0)
        Me.picFranchise2.Name = "picFranchise2"
        Me.picFranchise2.Size = New System.Drawing.Size(154, 130)
        Me.picFranchise2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFranchise2.TabIndex = 1
        Me.picFranchise2.TabStop = False
        '
        'lstDisplay
        '
        Me.lstDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDisplay.ForeColor = System.Drawing.Color.LightSlateGray
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.ItemHeight = 24
        Me.lstDisplay.Items.AddRange(New Object() {"Buffalo Wild Wings", "Cold Stone Creamery", "Firehouse Subs", "Genghis Grill", "Mellow Mushroom", "Papa Murphys", "Ritas Italian Ice", "Saladworks", "Scooters Coffee", "Smoothie King", "Qdoba Mexican Grill"})
        Me.lstDisplay.Location = New System.Drawing.Point(169, 97)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(230, 196)
        Me.lstDisplay.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightSlateGray
        Me.Label1.Location = New System.Drawing.Point(163, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(296, 34)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Franchise Investment"
        '
        'frmDisplay
        '
        Me.AcceptButton = Me.btnReturn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(477, 435)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.picFranchise2)
        Me.Controls.Add(Me.btnReturn)
        Me.Name = "frmDisplay"
        Me.Text = "Display"
        CType(Me.picFranchise2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnReturn As Button
    Friend WithEvents picFranchise2 As PictureBox
    Friend WithEvents lstDisplay As ListBox
    Friend WithEvents Label1 As Label
End Class
