Imports System.Runtime.InteropServices

Public Class Form1
	Private Structure visitinfo
		Dim visited As Boolean
		Dim from As Point
	End Structure

	Dim img As Bitmap

	Private Sub ファイルを開くOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ファイルを開くOToolStripMenuItem.Click
		If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
			img = New Bitmap(OpenFileDialog1.FileName)
			PictureBox1.Image = img
		End If
	End Sub

	Private Sub PictureBox1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox1.DragEnter
		If e.Data.GetDataPresent(DataFormats.FileDrop) Then
			e.Effect = DragDropEffects.Copy
		Else
			e.Effect = DragDropEffects.None
		End If
	End Sub

	Private Sub PictureBox1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox1.DragDrop
		OpenFileDialog1.FileName = CType(e.Data.GetData(DataFormats.FileDrop, False), String())(0)
		img = New Bitmap(OpenFileDialog1.FileName)
		PictureBox1.Image = img
	End Sub

	Dim start As Point
	Dim goal As Point

	Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
		If (Control.ModifierKeys And Keys.Control) = Keys.Control Then
			goal = New Point(e.X, e.Y)

			img = New Bitmap(OpenFileDialog1.FileName)
			PictureBox1.Image = img

			Dim map(img.Height - 1, img.Width - 1) As Boolean
			Dim visited(img.Height - 1, img.Width - 1) As visitinfo

			Dim bmpdata As Imaging.BitmapData = img.LockBits(New Rectangle(0, 0, img.Width, img.Height), Imaging.ImageLockMode.ReadOnly, Imaging.PixelFormat.Format24bppRgb)
			Dim pixels As Byte() = New Byte(bmpdata.Stride * bmpdata.Height - 1) {}
			Marshal.Copy(bmpdata.Scan0, pixels, 0, pixels.Length)

			For y = 0 To img.Height - 1
				Dim pos As Integer = y * bmpdata.Stride
				For x = 0 To img.Width - 1
					If pixels(pos) < 128 Then
						map(y, x) = True
					Else
						map(y, x) = False
					End If
					pos += 3
				Next
			Next


			img.UnlockBits(bmpdata)


			solve_maze(map, visited)
		Else
			start = New Point(e.X, e.Y)
		End If
	End Sub

	'TODO:無効なfromで判定するとvisited不要?

	Private Sub solve_maze(ByRef map(,) As Boolean, ByRef visited(,) As visitinfo)
		visited(start.Y, start.X).from = start
		visited(start.Y, start.X).visited = True

		Dim tansaku As New Queue(Of Point)
		tansaku.Enqueue(start)

		Do While tansaku.Count > 0
			Dim nex As Point = tansaku.Dequeue()
			If CheckBox2.Checked Then

				PictureBox1.CreateGraphics.FillRectangle(Brushes.Blue, nex.X, nex.Y, 1, 1)
			End If
			If nex.X = goal.X AndAlso nex.Y = goal.Y Then
				Exit Do
			End If
			'HACK:Try無双やめよう
			Try
				If Not visited(nex.Y, nex.X + 1).visited Then
					If Not map(nex.Y, nex.X + 1) Then
						visited(nex.Y, nex.X + 1).from = nex
						visited(nex.Y, nex.X + 1).visited = True
						tansaku.Enqueue(New Point(nex.X + 1, nex.Y))
					End If
				End If
			Catch ex As Exception
			End Try
			Try
				If Not visited(nex.Y + 1, nex.X).visited Then
					If Not map(nex.Y + 1, nex.X) Then
						visited(nex.Y + 1, nex.X).from = nex
						visited(nex.Y + 1, nex.X).visited = True
						tansaku.Enqueue(New Point(nex.X, nex.Y + 1))
					End If
				End If
			Catch ex As Exception
			End Try
			Try
				If Not visited(nex.Y, nex.X - 1).visited Then
					If Not map(nex.Y, nex.X - 1) Then
						visited(nex.Y, nex.X - 1).from = nex
						visited(nex.Y, nex.X - 1).visited = True
						tansaku.Enqueue(New Point(nex.X - 1, nex.Y))
					End If
				End If
			Catch ex As Exception
			End Try
			Try
				If Not visited(nex.Y - 1, nex.X).visited Then
					If Not map(nex.Y - 1, nex.X) Then
						visited(nex.Y - 1, nex.X).from = nex
						visited(nex.Y - 1, nex.X).visited = True
						tansaku.Enqueue(New Point(nex.X, nex.Y - 1))
					End If
				End If
			Catch ex As Exception
			End Try
			Application.DoEvents()
		Loop

		PictureBox1.Image = img
		Dim g As Graphics = Graphics.FromImage(img)
		Dim x As Integer = goal.X
		Dim y As Integer = goal.Y
		Do
			g.FillRectangle(Brushes.Red, visited(y, x).from.X, visited(y, x).from.Y, 1, 1)
			x = visited(y, x).from.X
			y = visited(y, x).from.Y
		Loop Until x = start.X AndAlso y = start.Y

		If CheckBox1.Checked Then
			If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
				img.Save(SaveFileDialog1.FileName, Imaging.ImageFormat.Png)
			End If
		End If
	End Sub

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
		PictureBox1.AllowDrop = True
	End Sub
End Class