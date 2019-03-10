''' <summary>
''' メッセージボックスの種類を管理
''' </summary>
''' <remarks></remarks>
Public Class clsMessageBoxButtonInfo

#Region "Property"

	Private _enumIndex As MessageBoxButtons = MessageBoxButtons.OK
	''' <summary>
	''' 定義されたインデックス
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public ReadOnly Property EnumIndex() As MessageBoxButtons
		Get
			Return _enumIndex
		End Get
	End Property

	Private _buttonsText As String = String.Empty
	''' <summary>
	''' 表示されるボタンのテキスト
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public ReadOnly Property ButtonsText() As String
		Get
			Return _buttonsText
		End Get
	End Property

	Private _buttons As Integer
	''' <summary>
	''' 表示されるボタンの数
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public ReadOnly Property Buttons() As Integer
		Get
			Return _buttons
		End Get
	End Property

	''' <summary>
	''' 設定できるデフォルトボタンの最大値を取得
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public ReadOnly Property MaxDefBuntton() As Integer
		Get
			If Me._buttons = 0 Then
				Return 0
			ElseIf Me._buttons = 1 Then
				Return MessageBoxDefaultButton.Button1
			ElseIf Me._buttons = 2 Then
				Return MessageBoxDefaultButton.Button2
			ElseIf Me._buttons = 3 Then
				Return MessageBoxDefaultButton.Button3
			Else
				Return 0
			End If
		End Get
	End Property


	'Private _definedDefaultButton As MessageBoxDefaultButton = MessageBoxDefaultButton.Button1
	' ''' <summary>
	' ''' もともとのデフォルトボタン
	' ''' </summary>
	' ''' <value></value>
	' ''' <returns></returns>
	' ''' <remarks></remarks>
	'Public ReadOnly Property DefinedDefaultButton() As MessageBoxDefaultButton
	'	Get
	'		Return _definedDefaultButton
	'	End Get
	'End Property

	Private _defaultButton As MessageBoxDefaultButton = MessageBoxDefaultButton.Button1
	''' <summary>
	''' デフォルトで選択状態にするボタン
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property DefaultButton() As MessageBoxDefaultButton
		Get
			Return _defaultButton
		End Get
		Set(ByVal value As MessageBoxDefaultButton)
			If value <= Me.MaxDefBuntton Then
				' MessageBoxDefaultButtonはボタン数-1の値が格納されているので、ボタン数と比較して代入
				_defaultButton = value
			End If
		End Set
	End Property

#End Region

#Region "Function"

	''' <summary>
	''' 複製
	''' </summary>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Function Clone() As clsMessageBoxButtonInfo
		Dim myClone As clsMessageBoxButtonInfo = Nothing

		myClone = New clsMessageBoxButtonInfo
		With myClone
			._enumIndex = Me.EnumIndex
			._buttonsText = Me.ButtonsText
			._buttons = Me.Buttons
			._defaultButton = Me.DefaultButton
		End With

		Return myClone
	End Function

	''' <summary>
	''' 指定したメッセージボックスボタンの列挙値から自分自身を作成
	''' </summary>
	''' <param name="enmMsgBoxButtons"></param>
	''' <remarks></remarks>
	Public Function MakeMeFromMessageBoxButtons(ByVal enmMsgBoxButtons As MessageBoxButtons) As Boolean
		Dim successed As Boolean = True

		'引数が列挙値なら変な値は来ないはず
		Me._enumIndex = enmMsgBoxButtons

		Select Case enmMsgBoxButtons
			Case MessageBoxButtons.OK
				Me._buttons = 1
				Me._buttonsText = "OKのみ"

			Case MessageBoxButtons.OKCancel
				Me._buttons = 2
				Me._buttonsText = "OK・キャンセル"

			Case MessageBoxButtons.AbortRetryIgnore
				Me._buttons = 3
				Me._buttonsText = "中止・再試行・無視"

			Case MessageBoxButtons.YesNoCancel
				Me._buttons = 3
				Me._buttonsText = "はい・いいえ・キャンセル"

			Case MessageBoxButtons.YesNo
				Me._buttons = 2
				Me._buttonsText = "はい・いいえ"

			Case MessageBoxButtons.RetryCancel
				Me._buttons = 2
				Me._buttonsText = "再試行・キャンセル"

			Case Else
				successed = False

		End Select

		Return successed
	End Function

	''' <summary>
	''' 自分自身のスタイルに合わせてメッセージボックスを表示
	''' </summary>
	''' <param name="title">タイトル</param>
	''' <param name="body">本文</param>
	''' <remarks></remarks>
	Public Sub ShowMessageBox(ByVal title As String, ByVal body As String, ByVal iconMode As MessageBoxIcon)
		MessageBox.Show(body, title, Me._enumIndex, iconMode, Me._defaultButton)
	End Sub

#End Region

End Class
