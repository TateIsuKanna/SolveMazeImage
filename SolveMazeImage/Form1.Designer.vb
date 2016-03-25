<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
	Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.ファイルFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ファイルを開くOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.MenuStrip1.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'MenuStrip1
		'
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ファイルFToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
		Me.MenuStrip1.Size = New System.Drawing.Size(713, 24)
		Me.MenuStrip1.TabIndex = 1
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'ファイルFToolStripMenuItem
		'
		Me.ファイルFToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ファイルを開くOToolStripMenuItem})
		Me.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem"
		Me.ファイルFToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
		Me.ファイルFToolStripMenuItem.Text = "ファイル(&F)"
		'
		'ファイルを開くOToolStripMenuItem
		'
		Me.ファイルを開くOToolStripMenuItem.Name = "ファイルを開くOToolStripMenuItem"
		Me.ファイルを開くOToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
		Me.ファイルを開くOToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
		Me.ファイルを開くOToolStripMenuItem.Text = "ファイルを開く(&O)"
		'
		'SaveFileDialog1
		'
		Me.SaveFileDialog1.DefaultExt = "png"
		'
		'PictureBox1
		'
		Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.PictureBox1.Location = New System.Drawing.Point(0, 24)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(713, 447)
		Me.PictureBox1.TabIndex = 2
		Me.PictureBox1.TabStop = False
		'
		'Label1
		'
		Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(453, 24)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(260, 12)
		Me.Label1.TabIndex = 3
		Me.Label1.Text = "スタート指定:クリック,ゴール指定:Ctrlを押しながらクリック"
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(713, 471)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.MenuStrip1)
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Name = "Form1"
		Me.Text = "SolveMazeImage自称便利な迷路解き"
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents OpenFileDialog1 As OpenFileDialog
	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents ファイルFToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ファイルを開くOToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents SaveFileDialog1 As SaveFileDialog
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Label1 As Label
End Class
