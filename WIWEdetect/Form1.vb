﻿Imports System.Threading
Imports System.Diagnostics
Public Class Form1
    Private trd As Thread
    Private trdLabel As Thread

    Private Sub ButtonScan_Click(sender As Object, e As EventArgs) Handles ButtonScan.Click
        LabelStatus.Text = "Keresés..."
        TextBoxScanResult.Text = vbNullString
        TextBoxWIWE.Text = vbNullString
        'trdLabel = New Thread(AddressOf ThreadTaskLabel)
        'trdLabel.Priority = ThreadPriorityLevel.Highest
        'trdLabel.IsBackground = True
        'trdLabel.Start()
        trd = New Thread(AddressOf ThreadTask)
        trd.Priority = ThreadPriorityLevel.Normal
        trd.IsBackground = True
        Debug.Print("Thread starts: " & Now)
        trd.Start()

    End Sub
    Private Sub ThreadTaskLabel()
        Call SetLabelText("Keresés...")
    End Sub
    Private Sub ThreadTask()
        'A BT kezelés külön threadben legyen, különben elsőbbséget élvez
        'és nem enged a futás végéig semmit csinálni
        Dim bc As New InTheHand.Net.Sockets.BluetoothClient()
        Dim deviceArray As InTheHand.Net.Sockets.BluetoothDeviceInfo() = bc.DiscoverDevices()
        Dim count As Integer = deviceArray.Length
        Dim sText As String
        Dim fullText As String
        Dim hNap As String
        Dim hSap As String
        Dim hMac As String
        Dim intWIWECount As Integer
        sText = vbNullString
        fullText = vbNullString
        intWIWECount = 0
        For i As Integer = 0 To count - 1
            hNap = Hex(deviceArray(i).DeviceAddress.Nap)
            hSap = Hex(deviceArray(i).DeviceAddress.Sap)
            hMac = hNap & hSap

            fullText = GetFullText(deviceArray(i).DeviceName, hNap, hSap)

            Console.WriteLine(fullText)
            Debug.Print(fullText)
            Me.SetScanText(fullText)
            'TextBoxScanResult.Text = fullText
        Next
        'LabelStatus.Text = ""
        Me.SetLabelText("")
        'LabelStatus.Text = "Keresés..."
    End Sub
    Private Function GetFullText(device_name As String, device_nap As String, device_sap As String) As String
        Dim res As String
        res = "---" & Now.ToString & "-----------------------" & vbCrLf
        res = res & device_name & vbCrLf
        res = res & device_nap & device_sap & vbCrLf
        Return res
    End Function
    Private Function IsWIWE(device_name As String, device_nap As String) As Boolean
        Dim res As Boolean
        res = False

        Return res
    End Function


    'Threadsafe control handling
    Delegate Sub SetTextCallback([text] As String)
    Delegate Sub SetLabelTextCallback([text] As String)
    Private Sub SetScanText(ByVal [text] As String)
        ' InvokeRequired required compares the thread ID of the
        ' calling thread to the thread ID of the creating thread.
        ' If these threads are different, it returns true.
        If Me.TextBoxScanResult.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf SetScanText)
            Me.Invoke(d, New Object() {[text]})
        Else
            Me.TextBoxScanResult.Text = [text]
        End If
    End Sub
    Private Sub SetLabelText(ByVal [text] As String)
        ' InvokeRequired required compares the thread ID of the
        ' calling thread to the thread ID of the creating thread.
        ' If these threads are different, it returns true.
        If Me.LabelStatus.InvokeRequired Then
            Dim d As New SetLabelTextCallback(AddressOf SetLabelText)
            Me.Invoke(d, New Object() {[text]})
        Else
            Me.LabelStatus.Text = [text]
        End If
    End Sub
End Class
