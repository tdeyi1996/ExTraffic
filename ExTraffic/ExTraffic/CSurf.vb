Imports System.Net

Public Class CSurf

    Public Function GetHash(ByVal link As String) As String
        Try
            Dim web As New Net.WebClient
            web.Headers.Add(Net.HttpRequestHeader.UserAgent, "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.1 (KHTML, like Gecko) Chrome/21.0.1180.83 Safari/537.1")
            web.Headers.Add(Net.HttpRequestHeader.Accept, "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8")
            web.Headers.Add(Net.HttpRequestHeader.AcceptCharset, "windows-1250,utf-8;q=0.7,*;q=0.3")
            web.Headers.Add(Net.HttpRequestHeader.AcceptEncoding, "gzip,deflate,sdch")
            web.Headers.Add(Net.HttpRequestHeader.AcceptLanguage, "hr-HR,hr;q=0.8,en-US;q=0.6,en;q=0.4")
            web.Headers.Add(Net.HttpRequestHeader.Host, "adfoc.us")
            Dim hash As String = Split(Split(web.DownloadString(link), "&servehash=")(1), "&timestamp=")(0)
            Return hash
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function Navigate(ByVal link As String, ByVal key As String) As Boolean
        Try
            Dim web As New Net.WebClient
            web.Headers.Add(Net.HttpRequestHeader.UserAgent, "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.1 (KHTML, like Gecko) Chrome/21.0.1180.83 Safari/537.1")
            web.Headers.Add(Net.HttpRequestHeader.Accept, "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8")
            web.Headers.Add(Net.HttpRequestHeader.AcceptCharset, "windows-1250,utf-8;q=0.7,*;q=0.3")
            web.Headers.Add(Net.HttpRequestHeader.AcceptEncoding, "gzip,deflate,sdch")
            web.Headers.Add(Net.HttpRequestHeader.AcceptLanguage, "hr-HR,hr;q=0.8,en-US;q=0.6,en;q=0.4")
            web.Headers.Add(Net.HttpRequestHeader.ContentType, "application/x-www-form-urlencoded")
            web.Headers.Add(Net.HttpRequestHeader.Host, "adfoc.us")
            web.Headers.Add(Net.HttpRequestHeader.Referer, link)
            web.Headers.Add("X-Requested-With", "XMLHttpRequest")
            web.UploadString("http://adfoc.us/serve/credit", "POST", "key=" & key)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function Surf(ByVal link As String)
        Try
            Navigate(link, GetHash(link))
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class