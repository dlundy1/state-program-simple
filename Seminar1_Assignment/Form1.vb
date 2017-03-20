Public Class usa_lookup

    Dim States() As String = {"ALABAMA", "ALASKA", "AMERICAN SAMOA", "ARIZONA", "ARKANSAS", "CALIFORNIA", "COLORADO", "CONNETICUT", "DELAWARE", "DISTRICT OF COLUMBIA", "FLORIDA", "GEORGIA", "GUAM", "HAWAII", "IDAHO", "ILLINOIS", "INDIANA", "IOWA", "KANSAS", "KENTUCKY", "LOUISIANA", "MAINE", "MARYLAND", "MASSACHUSETTS", "MICHIGAN", "MINNESOTA", "MISSISSIPPI", "MISSOURI", "MONTANA", "NEBRASKA", "NEVADA", "NEW HAMPSHIRE", "NEW JERSEY", "NEW MEXICO", "NEW YORK", "NORTH CAROLINA", "NORTH DAKOTA", "OHIO", "OKLAHOMA", "OREGON", "PENNYSYLVANIA", "PUERTO RICO", "RHODE ISLAND", "SOUTH CAROLINA", "SOUTH DAKOTA", "TENNESSEE", "TEXAS", "TRUST TERRITORIES", "UTAH", "VERMONT", "VIRGINIA", "VIRGIN ISLANDS", "WASHINGTON", "WEST VIRGINIA", "WISCONSIN", "WYOMING"}
    Dim Abbrev() As String = {"AL", "AK", "AS", "AZ", "AR", "CA", "CO", "CT", "DE", "DC", "FL", "GA", "GU", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "PR", "RI", "SC", "SD", "TN", "TX", "TT", "UT", "VT", "VA", "VI", "WA", "WV", "WI", "WY"}

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        GroupBox1.Enabled = True
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles state_check.CheckedChanged
        search_button.Text = "State Lookup"
        Label2.Text = "Enter Abbrev."
    End Sub

    Private Sub usa_lookup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles search_button.Click
        If (state_check.Checked = False And abbrev_check.Checked = False) Then
            MessageBox.Show("You Must Select One Option", "No Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (user_input.Text = "") Then
            MessageBox.Show("You Must Provide Search Input", "No Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            If (found()) Then
                '' begin data processing.
                Debug.WriteLine("YES YES YES")
                processData()
            ElseIf (state_check.Checked = True) Then
                Debug.WriteLine("NO NO NO")
                MessageBox.Show("Invalid. You must enter an ABBREVIATION", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Debug.WriteLine("NO NO NO")
                MessageBox.Show("Invalid. You must enter STATE/TERRITORY Name", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
    Private Function found() As Boolean
        '' Check States Array for value
        If (state_check.Checked = True) Then
            For Each locate As String In Abbrev
                If (user_input.Text.ToUpper() = locate) Then
                    Return True
                End If
            Next locate
        ElseIf (abbrev_check.Checked = True) Then
            '' Check Abbrev Array for Value
            For Each locate As String In States
                If (user_input.Text.ToUpper() = locate) Then
                    Return True
                End If
            Next locate
        Else
            Return False
        End If

        '' end Check
    End Function

    Private Sub processData()
        Debug.WriteLine("inside process1")
        If (state_check.Checked = True) Then
            Debug.WriteLine("If Activated:  ")
            Dim obj1 As New Form2()
            Debug.WriteLine("Object Declared")
            ''Looking for State, input abbrev
            For Each input As String In Abbrev
                '' statements
                If (user_input.Text.ToUpper() = input) Then
                    Dim spot As Integer
                    spot = Array.IndexOf(Abbrev, input)

                    obj1.abbrev_output.Text = input
                    obj1.state_output.Text = States(spot)
                    ''''
                    Debug.WriteLine(spot)
                    Debug.WriteLine(input)
                    Debug.WriteLine("Right before open Dialog")

                    obj1.ShowDialog()
                End If
                ''Debug.WriteLine(input)
            Next input
        Else
            Dim obj2 As New Form2()
            '' Looking for abbrev, input State
            For Each input As String In States
                '' statements
                If (user_input.Text.ToUpper() = input) Then
                    Dim spot As Integer
                    spot = Array.IndexOf(States, input)
                    Debug.WriteLine("inside ELSE:  ")
                    Debug.WriteLine(spot)

                    Debug.WriteLine("Found ")
                    obj2.state_output.Text = input
                    obj2.abbrev_output.Text = Abbrev(spot)

                    obj2.ShowDialog()
                End If
                ''Debug.WriteLine(input)
            Next input
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub CheckBox1_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckStateChanged
        If (CheckBox1.CheckState = CheckState.Checked) Then
            GroupBox1.Enabled = True
            user_input.Enabled = True
        Else
            GroupBox1.Enabled = False
            user_input.Enabled = False
        End If
    End Sub

    Private Sub abbrev_check_CheckedChanged(sender As Object, e As EventArgs) Handles abbrev_check.CheckedChanged
        search_button.Text = "Abbrev. Lookup"
        Label2.Text = "Enter Name"
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        user_input.Text = ""
        state_check.Checked = False
        abbrev_check.Checked = False
    End Sub
End Class
