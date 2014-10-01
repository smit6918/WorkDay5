Public Class Form1

    Private Sub btnShowRecipe_Click(sender As Object, e As EventArgs) Handles btnShowRecipe.Click
        CookChicken()
        PullTheMeat()
        AddVeggies()
        AddNoodles()
        MessageBox.Show("Simmer on medium low for 8-10 min")
    End Sub

    Sub CookChicken()
        MessageBox.Show("Defrost a plate of chicken legs")
        MessageBox.Show("Cover the chicken with 4 quarts of water")
        MessageBox.Show("Bring the pot to a boil.")
        MessageBox.Show("Simmer the chicken for 30 minutes.")
    End Sub

    Sub PullTheMeat()
        MessageBox.Show("Grab a couple of forks")
        MessageBox.Show("Pull the meat of the bones")
    End Sub

    Sub AddVeggies()
        CutVeggies()
        MessageBox.Show("Add cut veggies to the broth")
    End Sub

    Sub CutVeggies()
        MessageBox.Show("Cut carrots")
        MessageBox.Show("Cut onion")
    End Sub

    Sub AddNoodles()
        MessageBox.Show("Add noodles and increase heat")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
