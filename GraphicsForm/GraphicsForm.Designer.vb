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
        components = New ComponentModel.Container()
        ColorDialog = New ColorDialog()
        ContextMenuStrip = New ContextMenuStrip(components)
        ChooseColorContextMenuItem = New ToolStripMenuItem()
        ClearConextMenuItem = New ToolStripMenuItem()
        PictureBox = New PictureBox()
        ContextMenuStrip.SuspendLayout()
        CType(PictureBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ContextMenuStrip
        ' 
        ContextMenuStrip.Items.AddRange(New ToolStripItem() {ChooseColorContextMenuItem, ClearConextMenuItem})
        ContextMenuStrip.Name = "ContextMenuStrip"
        ContextMenuStrip.Size = New Size(147, 48)
        ' 
        ' ChooseColorContextMenuItem
        ' 
        ChooseColorContextMenuItem.Name = "ChooseColorContextMenuItem"
        ChooseColorContextMenuItem.Size = New Size(146, 22)
        ChooseColorContextMenuItem.Text = "&Choose Color"
        ' 
        ' ClearConextMenuItem
        ' 
        ClearConextMenuItem.Name = "ClearConextMenuItem"
        ClearConextMenuItem.Size = New Size(146, 22)
        ClearConextMenuItem.Text = "C&lear"
        ' 
        ' PictureBox
        ' 
        PictureBox.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox.BackColor = SystemColors.ControlText
        PictureBox.BorderStyle = BorderStyle.Fixed3D
        PictureBox.ContextMenuStrip = ContextMenuStrip
        PictureBox.Cursor = Cursors.Cross
        PictureBox.Location = New Point(12, 12)
        PictureBox.MinimumSize = New Size(360, 200)
        PictureBox.Name = "PictureBox"
        PictureBox.Size = New Size(720, 400)
        PictureBox.TabIndex = 1
        PictureBox.TabStop = False
        ' 
        ' GraphicsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(744, 511)
        Controls.Add(PictureBox)
        Name = "GraphicsForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ContextMenuStrip.ResumeLayout(False)
        CType(PictureBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents ColorDialog As ColorDialog
    Friend WithEvents ContextMenuStrip As ContextMenuStrip
    Friend WithEvents ChooseColorContextMenuItem As ToolStripMenuItem
    Friend WithEvents ClearConextMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox As PictureBox
End Class
