<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainProgram
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
        Me.btnAddPassword = New System.Windows.Forms.Button()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblPasswordsHeader = New System.Windows.Forms.Label()
        Me.lblDescriptionsHeader = New System.Windows.Forms.Label()
        Me.tableLayoutPass = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAddPassword
        '
        Me.btnAddPassword.Enabled = False
        Me.btnAddPassword.Location = New System.Drawing.Point(670, 405)
        Me.btnAddPassword.Name = "btnAddPassword"
        Me.btnAddPassword.Size = New System.Drawing.Size(118, 33)
        Me.btnAddPassword.TabIndex = 0
        Me.btnAddPassword.Text = "Add"
        Me.btnAddPassword.UseVisualStyleBackColor = True
        '
        'txtDescription
        '
        Me.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDescription.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.txtDescription.Location = New System.Drawing.Point(12, 409)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(320, 26)
        Me.txtDescription.TabIndex = 6
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPassword.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.txtPassword.Location = New System.Drawing.Point(338, 409)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(320, 26)
        Me.txtPassword.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 394)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(335, 394)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Password"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoScroll = True
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.92272!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.07728!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblPasswordsHeader, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDescriptionsHeader, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.MaximumSize = New System.Drawing.Size(0, 330)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 29)
        Me.TableLayoutPanel1.TabIndex = 14
        '
        'lblPasswordsHeader
        '
        Me.lblPasswordsHeader.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPasswordsHeader.AutoSize = True
        Me.lblPasswordsHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.lblPasswordsHeader.Location = New System.Drawing.Point(439, 4)
        Me.lblPasswordsHeader.Name = "lblPasswordsHeader"
        Me.lblPasswordsHeader.Size = New System.Drawing.Size(83, 20)
        Me.lblPasswordsHeader.TabIndex = 1
        Me.lblPasswordsHeader.Text = "Password"
        '
        'lblDescriptionsHeader
        '
        Me.lblDescriptionsHeader.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDescriptionsHeader.AutoSize = True
        Me.lblDescriptionsHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.lblDescriptionsHeader.Location = New System.Drawing.Point(112, 4)
        Me.lblDescriptionsHeader.Name = "lblDescriptionsHeader"
        Me.lblDescriptionsHeader.Size = New System.Drawing.Size(95, 20)
        Me.lblDescriptionsHeader.TabIndex = 0
        Me.lblDescriptionsHeader.Text = "Description"
        '
        'tableLayoutPass
        '
        Me.tableLayoutPass.AutoScroll = True
        Me.tableLayoutPass.AutoScrollMargin = New System.Drawing.Size(900, 0)
        Me.tableLayoutPass.AutoSize = True
        Me.tableLayoutPass.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tableLayoutPass.BackColor = System.Drawing.Color.White
        Me.tableLayoutPass.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial
        Me.tableLayoutPass.ColumnCount = 4
        Me.tableLayoutPass.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.31546!))
        Me.tableLayoutPass.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.68454!))
        Me.tableLayoutPass.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.tableLayoutPass.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79.0!))
        Me.tableLayoutPass.Dock = System.Windows.Forms.DockStyle.Top
        Me.tableLayoutPass.Location = New System.Drawing.Point(0, 29)
        Me.tableLayoutPass.MaximumSize = New System.Drawing.Size(800, 330)
        Me.tableLayoutPass.MinimumSize = New System.Drawing.Size(800, 0)
        Me.tableLayoutPass.Name = "tableLayoutPass"
        Me.tableLayoutPass.RowCount = 1
        Me.tableLayoutPass.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tableLayoutPass.Size = New System.Drawing.Size(800, 34)
        Me.tableLayoutPass.TabIndex = 17
        '
        'MainProgram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 448)
        Me.Controls.Add(Me.tableLayoutPass)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.btnAddPassword)
        Me.DoubleBuffered = True
        Me.Name = "MainProgram"
        Me.Text = "Form1"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAddPassword As Button
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblPasswordsHeader As Label
    Friend WithEvents lblDescriptionsHeader As Label
    Friend WithEvents tableLayoutPass As TableLayoutPanel
End Class
