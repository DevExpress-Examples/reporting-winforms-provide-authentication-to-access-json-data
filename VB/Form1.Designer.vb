Namespace Xtrareport_json_datasource_with_authorization

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.button2 = New System.Windows.Forms.Button()
            Me.label2 = New System.Windows.Forms.Label()
            Me.label1 = New System.Windows.Forms.Label()
            Me.button1 = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            ' 
            ' button2
            ' 
            Me.button2.Location = New System.Drawing.Point(15, 69)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(132, 23)
            Me.button2.TabIndex = 1
            Me.button2.Text = "Run Example 1"
            Me.button2.UseVisualStyleBackColor = True
            AddHandler Me.button2.Click, New System.EventHandler(AddressOf Me.CreateReportDataSourceWithAuthenticationInCodeButton_Click)
            ' 
            ' label2
            ' 
            Me.label2.Location = New System.Drawing.Point(12, 9)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(247, 57)
            Me.label2.TabIndex = 2
            Me.label2.Text = "Example 1:" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Create the JsonDataSource object based on the connection string that " & "includes authentication parameters."
            ' 
            ' label1
            ' 
            Me.label1.Location = New System.Drawing.Point(310, 9)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(247, 57)
            Me.label1.TabIndex = 4
            Me.label1.Text = "Example 2:" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Use the JsonDataSource's JsonSource to specify authentication paramet" & "ers in code."
            ' 
            ' button1
            ' 
            Me.button1.Location = New System.Drawing.Point(313, 69)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(132, 23)
            Me.button1.TabIndex = 3
            Me.button1.Text = "Run Example 2"
            Me.button1.UseVisualStyleBackColor = True
            AddHandler Me.button1.Click, New System.EventHandler(AddressOf Me.CreateReportDataSourceWithAuthenticationInCodeButton_Click)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(563, 129)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.button2)
            Me.Name = "Form1"
            Me.Text = "JsonDataSource with authorization"
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private button2 As System.Windows.Forms.Button

        Private label2 As System.Windows.Forms.Label

        Private label1 As System.Windows.Forms.Label

        Private button1 As System.Windows.Forms.Button
    End Class
End Namespace
