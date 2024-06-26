﻿'Rahiel Rodriguez
'RCET 0265
'Spring 2024
'Diner Menu Program
'https://github.com/rahielrodriguez/DinerMenu.git

Option Strict On
Option Explicit On
Public Class DinerMenuForm
    'TODO
    '[x]Set Soup Content
    '[x]Set Salad Content
    '[x]Set Fish Content
    '[x]Set Soup button function
    '[x]Set salad button function
    '[x]Set fish button function
    '[x]Set Exit button function
    '[x]Display each plate description
    Sub SoupContent()
        DisplaySpecialLabel.Text = "Indulge in Venezuelan comfort with our Andean Chicken Chupe. 
A savory blend of tender chicken, potatoes, and sweet corn, 
simmered to perfection in a flavorful broth. 
Topped with creamy table cream and fresh cheese squares, it's a heartwarming delight for any occasion."
    End Sub
    Sub SaladContent()
        DisplaySpecialLabel.Text = "Elevate your salad experience with our Venezuelan Chicken Salad. 
Succulent grilled chicken breast, tender mixed greens, and vibrant vegetables come together in a symphony 
of flavors. 
Tossed in a zesty citrus vinaigrette and topped with crispy plantain strips, 
it's a refreshing journey through the vibrant flavors of Venezuela. 
Embrace freshness and sophistication in every bite."
    End Sub
    Sub FishContent()
        DisplaySpecialLabel.Text = "Enjoy the authentic flavors of Venezuela with our Fried Fish paired with crispy Tostones. 
Tender fish fillets, marinated in garlic and seasoning, are fried to golden perfection. 
Served with traditional Tostones, thinly sliced green bananas fried until crispy and sprinkled with salt. 
Accompanied by a refreshing cabbage and carrot salad tossed in creamy mayonnaise dressing. 
Dive into this classic dish for a taste of Venezuelan culinary delight."
    End Sub
    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        SoupContent()

    End Sub
    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        SaladContent()

    End Sub
    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        FishContent()

    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
