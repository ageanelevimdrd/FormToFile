﻿Imports System.IO
Public Class Form1
    Dim sw1 As StreamWriter

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If NameBox.Text <> "" Or AgeBox.Text <> "" Or AddressBox.Text <> "" Then
            sw1 = File.AppendText("C:\Users\user\Documents\COLLEGE\Acads (5th yr)\electives3\FormToFile\FormToFile.txt")
            sw1.WriteLine(Label1.Text + NameBox.Text + vbNewLine + Label2.Text + AgeBox.Text + vbNewLine + Label3.Text + AddressBox.Text)
            MsgBox("Saved successfully!", MsgBoxStyle.Information, "Saved")
            NameBox.Clear()
            AgeBox.Clear()
            AddressBox.Clear()
            sw1.Close()
        Else
            MsgBox("Please input a data into boxes", MsgBoxStyle.Critical, "Input data")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If NameBox.Text <> "" Or AgeBox.Text <> "" Or AddressBox.Text <> "" Then
            sw1 = File.AppendText("C:\Users\user\Documents\COLLEGE\Acads (5th yr)\electives3\FormToFile\FormToFile.xml")
            sw1.WriteLine(Label1.Text + NameBox.Text + vbNewLine + Label2.Text + AgeBox.Text + vbNewLine + Label3.Text + AddressBox.Text)
            MsgBox("Saved successfully!", MsgBoxStyle.Information, "Saved")
            NameBox.Clear()
            AgeBox.Clear()
            AddressBox.Clear()
            sw1.Close()
        Else
            MsgBox("Please input a data into boxes", MsgBoxStyle.Critical, "Input data")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If NameBox.Text <> "" Or AgeBox.Text <> "" Or AddressBox.Text <> "" Then
            sw1 = File.AppendText("C:\Users\user\Documents\COLLEGE\Acads (5th yr)\electives3\FormToFile\FormToFile.json")
            sw1.WriteLine(Label1.Text + NameBox.Text + vbNewLine + Label2.Text + AgeBox.Text + vbNewLine + Label3.Text + AddressBox.Text)
            MsgBox("Saved successfully!", MsgBoxStyle.Information, "Saved")
            NameBox.Clear()
            AgeBox.Clear()
            AddressBox.Clear()
            sw1.Close()
        Else
            MsgBox("Please input a data into boxes", MsgBoxStyle.Critical, "Input data")
        End If
    End Sub
End Class
