<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GraphicsForm
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
        Me.components = New System.ComponentModel.Container()
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        Me.ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ChooseColorContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearConextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip.SuspendLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip
        '
        Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChooseColorContextMenuItem, Me.ClearConextMenuItem})
        Me.ContextMenuStrip.Name = "ContextMenuStrip"
        Me.ContextMenuStrip.Size = New System.Drawing.Size(147, 48)
        '
        'ChooseColorContextMenuItem
        '
        Me.ChooseColorContextMenuItem.Name = "ChooseColorContextMenuItem"
        Me.ChooseColorContextMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.ChooseColorContextMenuItem.Text = "&Choose Color"
        '
        'ClearConextMenuItem
        '
        Me.ClearConextMenuItem.Name = "ClearConextMenuItem"
        Me.ClearConextMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.ClearConextMenuItem.Text = "C&lear"
        '
        'PictureBox
        '
        Me.PictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox.ContextMenuStrip = Me.ContextMenuStrip
        Me.PictureBox.Cursor = System.Windows.Forms.Cursors.Cross
        Me.PictureBox.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(776, 369)
        Me.PictureBox.TabIndex = 1
        Me.PictureBox.TabStop = False
        '
        'GraphicsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox)
        Me.Name = "GraphicsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ContextMenuStrip.ResumeLayout(False)
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ColorDialog As ColorDialog
    Friend WithEvents ContextMenuStrip As ContextMenuStrip
    Friend WithEvents ChooseColorContextMenuItem As ToolStripMenuItem
    Friend WithEvents ClearConextMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox As PictureBox
End Class
