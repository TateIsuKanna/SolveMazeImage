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
		Me.CheckBox1 = New System.Windows.Forms.CheckBox()
		Me.CheckBox2 = New System.Windows.Forms.CheckBox()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.MenuStrip1.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel1.SuspendLayout()
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
		Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(335, 218)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
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
		'CheckBox1
		'
		Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.CheckBox1.AutoSize = True
		Me.CheckBox1.Location = New System.Drawing.Point(632, 39)
		Me.CheckBox1.Name = "CheckBox1"
		Me.CheckBox1.Size = New System.Drawing.Size(81, 16)
		Me.CheckBox1.TabIndex = 4
		Me.CheckBox1.Text = "結果を保存"
		Me.CheckBox1.UseVisualStyleBackColor = True
		'
		'CheckBox2
		'
		Me.CheckBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.CheckBox2.AutoSize = True
		Me.CheckBox2.Location = New System.Drawing.Point(608, 61)
		Me.CheckBox2.Name = "CheckBox2"
		Me.CheckBox2.Size = New System.Drawing.Size(105, 16)
		Me.CheckBox2.TabIndex = 5
		Me.CheckBox2.Text = "探索過程を表示"
		Me.CheckBox2.UseVisualStyleBackColor = True
		'
		'Panel1
		'
		Me.Panel1.AutoScroll = True
		Me.Panel1.Controls.Add(Me.PictureBox1)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel1.Location = New System.Drawing.Point(0, 24)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(713, 447)
		Me.Panel1.TabIndex = 6
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(713, 471)
		Me.Controls.Add(Me.CheckBox2)
		Me.Controls.Add(Me.CheckBox1)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.MenuStrip1)
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Name = "Form1"
		Me.Text = "SolveMazeImage自称便利な迷路解き"
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
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
	Friend WithEvents CheckBox1 As CheckBox
	Friend WithEvents CheckBox2 As CheckBox
	Friend WithEvents Panel1 As Panel
End Class
