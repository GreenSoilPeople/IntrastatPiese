Imports System.Text
Imports IntrastatPiese
Imports Microsoft.VisualStudio.TestTools.UnitTesting


<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub TestMethod1()
        Assert.IsInstanceOfType(New IntraFile, GetType(IntraFile))
    End Sub

End Class