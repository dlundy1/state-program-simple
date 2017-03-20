<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.abbrev_output = New System.Windows.Forms.TextBox()
        Me.state_output = New System.Windows.Forms.TextBox()
        Me.search_more_button = New System.Windows.Forms.Button()
        Me.quit_button = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(111, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search Results"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "STATE/TERR."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ABBREV:"
        '
        'abbrev_output
        '
        Me.abbrev_output.Location = New System.Drawing.Point(97, 96)
        Me.abbrev_output.Name = "abbrev_output"
        Me.abbrev_output.ReadOnly = True
        Me.abbrev_output.Size = New System.Drawing.Size(140, 20)
        Me.abbrev_output.TabIndex = 5
        Me.abbrev_output.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'state_output
        '
        Me.state_output.Location = New System.Drawing.Point(97, 70)
        Me.state_output.Name = "state_output"
        Me.state_output.ReadOnly = True
        Me.state_output.Size = New System.Drawing.Size(140, 20)
        Me.state_output.TabIndex = 6
        Me.state_output.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'search_more_button
        '
        Me.search_more_button.Location = New System.Drawing.Point(253, 56)
        Me.search_more_button.Name = "search_more_button"
        Me.search_more_button.Size = New System.Drawing.Size(102, 34)
        Me.search_more_button.TabIndex = 7
        Me.search_more_button.Text = "Search Again"
        Me.search_more_button.UseVisualStyleBackColor = True
        '
        'quit_button
        '
        Me.quit_button.Location = New System.Drawing.Point(253, 96)
        Me.quit_button.Name = "quit_button"
        Me.quit_button.Size = New System.Drawing.Size(102, 34)
        Me.quit_button.TabIndex = 8
        Me.quit_button.Text = "Quit Program"
        Me.quit_button.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Seminar1_Assignment.My.Resources.Resources.us_flag
        Me.PictureBox1.Location = New System.Drawing.Point(243, 137)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(140, 144)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(97, 13)
        Me.LinkLabel2.TabIndex = 10
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "US Federal Bureau"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(81, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Powered By"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 166)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.quit_button)
        Me.Controls.Add(Me.search_more_button)
        Me.Controls.Add(Me.state_output)
        Me.Controls.Add(Me.abbrev_output)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Results"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents abbrev_output As TextBox
    Friend WithEvents state_output As TextBox
    Friend WithEvents search_more_button As Button
    Friend WithEvents quit_button As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Label4 As Label
End Class
