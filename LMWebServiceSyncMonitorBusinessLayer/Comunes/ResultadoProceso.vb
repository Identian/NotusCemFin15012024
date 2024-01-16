﻿Namespace ClasesComunes
    Public Class ResultadoProceso

#Region "Atributos"

        Private _valor As Integer
        Private _mensaje As String

#End Region

#Region "Constructores"

        Public Sub New()
            MyBase.New()
            _mensaje = ""
        End Sub

        Public Sub New(ByVal valor As Integer, ByVal mensaje As String)
            MyBase.New()
            _valor = valor
            _mensaje = mensaje
        End Sub

#End Region

#Region "Propiedades"

        Public Property Valor() As Integer
            Get
                Return _valor
            End Get
            Set(ByVal value As Integer)
                _valor = value
            End Set
        End Property

        Public Property Mensaje() As String
            Get
                Return _mensaje
            End Get
            Set(ByVal value As String)
                _mensaje = value
            End Set
        End Property

#End Region

#Region "Métodos Públicos"

        Public Sub EstablecerValorYMensaje(ByVal valor As Integer, ByVal mensaje As String)
            _valor = valor
            _mensaje = mensaje
        End Sub

#End Region

    End Class

End Namespace