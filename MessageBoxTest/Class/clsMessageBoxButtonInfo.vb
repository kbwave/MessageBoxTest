''' <summary>
''' メッセージボックスの種類を管理
''' </summary>
''' <remarks></remarks>
Public Class clsMessageBoxButtonInfo

#Region "Property"

	Private _enumIndex As Integer = -1
	''' <summary>
	''' 定義されたインデックス
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public ReadOnly Property EnumIndex() As Integer
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
			If value <= Me._buttons - 1 Then
				' MessageBoxDefaultButtonはボタン数-1の値が格納されているので、ボタン数と比較して代入
				_defaultButton = value
			End If
		End Set
	End Property

#End Region

#Region "Function"




#End Region

End Class
