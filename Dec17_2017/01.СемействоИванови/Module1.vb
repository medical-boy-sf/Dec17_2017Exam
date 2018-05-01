Module Module1

    Sub Main()
        Dim budget As Double = Console.ReadLine()
        Dim pricePresentFirstChild As Double = Console.ReadLine()
        Dim pricePresentSecondChild As Double = Console.ReadLine()
        Dim pricePresentThirdChild As Double = Console.ReadLine()
        Dim priceTotal As Double = pricePresentFirstChild + pricePresentSecondChild + pricePresentThirdChild
        Dim charity As Double = (budget - priceTotal) * 0.9
        Console.WriteLine($"{charity:F2}")


    End Sub

End Module
