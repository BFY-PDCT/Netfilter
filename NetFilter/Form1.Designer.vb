<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.sitetxt = New System.Windows.Forms.TextBox()
        Me.USRTXT1 = New System.Windows.Forms.Label()
        Me.ADDBTN = New System.Windows.Forms.Button()
        Me.RELEASEBTN = New System.Windows.Forms.Button()
        Me.USRTXT2 = New System.Windows.Forms.Label()
        Me.USRTXT3 = New System.Windows.Forms.Label()
        Me.USRTXT4 = New System.Windows.Forms.Label()
        Me.APPLYBTN = New System.Windows.Forms.Button()
        Me.Bar = New System.Windows.Forms.Label()
        Me.QUITBTN = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MODIFYTXT = New System.Windows.Forms.Label()
        Me.SAVEDTXT = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 12
        Me.ListBox1.Location = New System.Drawing.Point(12, 134)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(776, 376)
        Me.ListBox1.TabIndex = 0
        '
        'sitetxt
        '
        Me.sitetxt.Location = New System.Drawing.Point(15, 106)
        Me.sitetxt.MaxLength = 1000
        Me.sitetxt.Name = "sitetxt"
        Me.sitetxt.Size = New System.Drawing.Size(324, 21)
        Me.sitetxt.TabIndex = 1
        '
        'USRTXT1
        '
        Me.USRTXT1.AutoSize = True
        Me.USRTXT1.Font = New System.Drawing.Font("Gulim", 9.0!)
        Me.USRTXT1.Location = New System.Drawing.Point(13, 91)
        Me.USRTXT1.Name = "USRTXT1"
        Me.USRTXT1.Size = New System.Drawing.Size(767, 12)
        Me.USRTXT1.TabIndex = 2
        Me.USRTXT1.Text = "차단할 사이트를 입력해주세요 (예시 : www.youtube.com, 주의 : 유효하지 않은 사이트 주소를 입력하여 생기는 피해는 책임지지 않습니" &
    "다.)"
        '
        'ADDBTN
        '
        Me.ADDBTN.Location = New System.Drawing.Point(345, 105)
        Me.ADDBTN.Name = "ADDBTN"
        Me.ADDBTN.Size = New System.Drawing.Size(75, 23)
        Me.ADDBTN.TabIndex = 3
        Me.ADDBTN.Text = "추가"
        Me.ADDBTN.UseVisualStyleBackColor = True
        '
        'RELEASEBTN
        '
        Me.RELEASEBTN.Location = New System.Drawing.Point(619, 105)
        Me.RELEASEBTN.Name = "RELEASEBTN"
        Me.RELEASEBTN.Size = New System.Drawing.Size(169, 23)
        Me.RELEASEBTN.TabIndex = 4
        Me.RELEASEBTN.Text = "선택한 사이트 차단 해제"
        Me.RELEASEBTN.UseVisualStyleBackColor = True
        '
        'USRTXT2
        '
        Me.USRTXT2.AutoSize = True
        Me.USRTXT2.Font = New System.Drawing.Font("Gulim", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.USRTXT2.Location = New System.Drawing.Point(12, 38)
        Me.USRTXT2.Name = "USRTXT2"
        Me.USRTXT2.Size = New System.Drawing.Size(252, 43)
        Me.USRTXT2.TabIndex = 5
        Me.USRTXT2.Text = "NETFILTER"
        '
        'USRTXT3
        '
        Me.USRTXT3.AutoSize = True
        Me.USRTXT3.Font = New System.Drawing.Font("Gulim", 15.0!)
        Me.USRTXT3.Location = New System.Drawing.Point(270, 61)
        Me.USRTXT3.Name = "USRTXT3"
        Me.USRTXT3.Size = New System.Drawing.Size(51, 20)
        Me.USRTXT3.TabIndex = 6
        Me.USRTXT3.Text = "V0.2"
        '
        'USRTXT4
        '
        Me.USRTXT4.AutoSize = True
        Me.USRTXT4.Location = New System.Drawing.Point(343, 38)
        Me.USRTXT4.Name = "USRTXT4"
        Me.USRTXT4.Size = New System.Drawing.Size(373, 24)
        Me.USRTXT4.TabIndex = 7
        Me.USRTXT4.Text = "시스템 파일 수정 방식으로 프로그램을 종료해도 차단이 유지됩니다." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "차단내용을 적용시킨 뒤에는 브라우저 등을 재시작해주세요"
        '
        'APPLYBTN
        '
        Me.APPLYBTN.Location = New System.Drawing.Point(426, 105)
        Me.APPLYBTN.Name = "APPLYBTN"
        Me.APPLYBTN.Size = New System.Drawing.Size(75, 23)
        Me.APPLYBTN.TabIndex = 8
        Me.APPLYBTN.Text = "적용"
        Me.APPLYBTN.UseVisualStyleBackColor = True
        '
        'Bar
        '
        Me.Bar.AutoSize = True
        Me.Bar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Bar.Font = New System.Drawing.Font("Gulim", 15.0!)
        Me.Bar.Location = New System.Drawing.Point(0, 0)
        Me.Bar.Name = "Bar"
        Me.Bar.Size = New System.Drawing.Size(800, 20)
        Me.Bar.TabIndex = 10
        Me.Bar.Text = "                                                                                 " &
    "                                "
        '
        'QUITBTN
        '
        Me.QUITBTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.QUITBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.QUITBTN.Location = New System.Drawing.Point(713, 65)
        Me.QUITBTN.Name = "QUITBTN"
        Me.QUITBTN.Size = New System.Drawing.Size(75, 23)
        Me.QUITBTN.TabIndex = 11
        Me.QUITBTN.Text = "종료"
        Me.QUITBTN.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(456, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 12)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "반드시 적용 버튼을 누른 뒤 종료해주세요"
        '
        'MODIFYTXT
        '
        Me.MODIFYTXT.AutoSize = True
        Me.MODIFYTXT.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.MODIFYTXT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MODIFYTXT.Location = New System.Drawing.Point(507, 110)
        Me.MODIFYTXT.Name = "MODIFYTXT"
        Me.MODIFYTXT.Size = New System.Drawing.Size(44, 12)
        Me.MODIFYTXT.TabIndex = 13
        Me.MODIFYTXT.Text = "수정중"
        '
        'SAVEDTXT
        '
        Me.SAVEDTXT.AutoSize = True
        Me.SAVEDTXT.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.SAVEDTXT.ForeColor = System.Drawing.Color.Lime
        Me.SAVEDTXT.Location = New System.Drawing.Point(557, 110)
        Me.SAVEDTXT.Name = "SAVEDTXT"
        Me.SAVEDTXT.Size = New System.Drawing.Size(44, 12)
        Me.SAVEDTXT.TabIndex = 14
        Me.SAVEDTXT.Text = "적용됨"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 522)
        Me.Controls.Add(Me.SAVEDTXT)
        Me.Controls.Add(Me.MODIFYTXT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.QUITBTN)
        Me.Controls.Add(Me.Bar)
        Me.Controls.Add(Me.APPLYBTN)
        Me.Controls.Add(Me.USRTXT4)
        Me.Controls.Add(Me.USRTXT3)
        Me.Controls.Add(Me.USRTXT2)
        Me.Controls.Add(Me.RELEASEBTN)
        Me.Controls.Add(Me.ADDBTN)
        Me.Controls.Add(Me.USRTXT1)
        Me.Controls.Add(Me.sitetxt)
        Me.Controls.Add(Me.ListBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents sitetxt As TextBox
    Friend WithEvents USRTXT1 As Label
    Friend WithEvents ADDBTN As Button
    Friend WithEvents RELEASEBTN As Button
    Friend WithEvents USRTXT2 As Label
    Friend WithEvents USRTXT3 As Label
    Friend WithEvents USRTXT4 As Label
    Friend WithEvents APPLYBTN As Button
    Friend WithEvents Bar As Label
    Friend WithEvents QUITBTN As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents MODIFYTXT As Label
    Friend WithEvents SAVEDTXT As Label
End Class
