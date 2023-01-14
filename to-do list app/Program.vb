Imports System.IO

Module Program


    Dim todoList As New List(Of String)

    Sub Main()
        'Read the to-do list from a text file
        If File.Exists("todo.txt") Then
            todoList.AddRange(File.ReadAllLines("todo.txt"))
        End If
        'Show the main menu
        ShowMenu()
    End Sub

    Private Sub ShowMenu()
        Console.Clear()
        Console.WriteLine("To-Do List")
        Console.WriteLine("1. Show list")
        Console.WriteLine("2. Add item")
        Console.WriteLine("3. Remove item")
        Console.WriteLine("4. Exit")
        Console.Write("Enter your choice: ")
        Select Case Console.ReadLine()
            Case "1"
                ShowList()
            Case "2"
                AddItem()
            Case "3"
                RemoveItem()
            Case "4"
                ExitApplication()
            Case Else
                Console.WriteLine("Invalid choice")
                Console.ReadKey()
                ShowMenu()
        End Select
    End Sub

    Private Sub ShowList()
        'Show the current to-do list
        Console.Clear()
        Console.WriteLine("To-Do List:")
        For Each item In todoList
            Console.WriteLine("- " & item)
        Next
        Console.WriteLine()
        Console.WriteLine("Press any key to go back")
        Console.ReadKey()
        ShowMenu()
    End Sub

    Private Sub AddItem()
        'Add a new item to the to-do list
        Console.Clear()
        Console.Write("Enter the new item: ")
        Dim newItem As String = Console.ReadLine()
        If newItem <> "" Then
            todoList.Add(newItem)
            Console.WriteLine("Item added successfully")
        Else
            Console.WriteLine("Invalid input")
        End If
        Console.ReadKey()
        ShowMenu()
    End Sub

    Private Sub RemoveItem()
        Try
            'Remove an item from the to-do list
            Console.Clear()
            Console.Write("Enter the item number to remove: ")
            Dim itemNum As Integer
            If Integer.TryParse(Console.ReadLine(), itemNum) AndAlso itemNum > 0 AndAlso itemNum <= todoList.Count Then
                todoList.RemoveAt(itemNum - 1)
                Console.WriteLine("Item removed successfully")
            Else
                Console.WriteLine("Invalid input")
            End If
            Console.ReadKey()
            ShowMenu()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub ExitApplication()
        Try
            'Save the to-do list to a text file
            File.WriteAllLines("todo.txt", todoList)
            'Exit the application
            End
        Catch ex As Exception

        End Try
    End Sub
    Private Sub kati()

    End Sub

End Module
