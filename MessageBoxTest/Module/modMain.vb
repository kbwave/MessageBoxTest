Imports System.Text

''' <summary>
''' 本アプリのメインモジュール
''' </summary>
''' <remarks></remarks>
Module modMain

#Region "Window"

	Private _windowMain As windowMain = Nothing

#End Region


	''' <summary>
	''' エントリーポイント
	''' </summary>
	''' <remarks></remarks>
	<STAThread> _
	Public Sub Main()
		If _windowMain Is Nothing Then
			_windowMain = New windowMain
		End If

		_windowMain.ShowDialog()
		_windowMain.Dispose()
	End Sub


	''' <summary>
	''' 書式化されたメッセージボックスの種類の文字列リストを取得
	''' </summary>
	''' <param name="codePosition">メッセージボックスの数値の位置(-1：種類の前、0：付けない、1：種類の後ろ)</param>
	''' <param name="separateString">種類との分割文字列</param>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Function GetFormattedStyleList(ByVal codePosition As Integer, ByVal separateString As String) As List(Of String)
		Dim styleItem As List(Of String) = Nothing
		Dim formattedStyleItem As List(Of String) = Nothing
		Dim addString As StringBuilder = Nothing

		addString = New StringBuilder
		addString.Capacity = 32

		styleItem = GetStyleList()

		formattedStyleItem = New List(Of String)
		For Each styleString As String In styleItem
			addString.Clear()

			Select Case codePosition
				Case modDefine.PositionNum.Before
					addString.Append("")

				Case modDefine.PositionNum.After


			End Select


			formattedStyleItem.Add("")
		Next

		Return formattedStyleItem
	End Function

	''' <summary>
	''' メッセージボックスの種類の文字列リストを取得
	''' </summary>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Function GetStyleList() As List(Of String)
		Dim styleItem As List(Of String) = Nothing
		styleItem = New List(Of String)

		For buttonsIndex As Integer = 0 To MessageBoxButtons.RetryCancel

		Next

		Return styleItem
	End Function


End Module
