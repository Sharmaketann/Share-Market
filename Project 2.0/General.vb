Imports System.Data
Imports System.Data.SqlClient

Module General
    Public connection As New SqlConnection
    Public command As New SqlCommand
    Public reader As SqlDataReader
    Public dataset As New DataSet
    Public adapter As New SqlDataAdapter

    Public user As String

End Module
