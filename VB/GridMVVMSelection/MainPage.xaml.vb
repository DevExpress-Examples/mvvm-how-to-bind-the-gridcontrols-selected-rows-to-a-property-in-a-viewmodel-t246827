Imports System.Windows.Controls
Imports Model

Namespace SLGridMVVMSelection
    Partial Public Class MainPage
        Inherits UserControl

        Public Sub New()
            InitializeComponent()
            DataContext = New ViewModel()
        End Sub
    End Class
End Namespace
