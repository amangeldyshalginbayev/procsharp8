Imports System
Imports CarLibrary

Module Program
    Sub Main()
        Console.WriteLine("***** VB CarLibrary Client App *****")
        Dim myMiniVan as New Minivan()
        myMiniVan.TurboBoost()
        
        Dim mySportsCar As New SportsCar()
        mySportsCar.TurboBoost()
        
        Dim dreamCar As New PerformanceCar()
        dreamCar.PetName = "Hank"
        dreamCar.TurboBoost()
        
        Dim internalClassInstance As New MyInternalClass()
        
        Console.ReadLine()
    End Sub
End Module
