 
    [AttributeUsage(AttributeTargets.Method)]
    public class STATestMethodAttribute : TestMethodAttribute
    {
        public override TestResult[] Execute(ITestMethod testMethod)
        {
            TestResult[] result = null;
            var thread = new Thread(() => result = base.Execute(testMethod));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();
            return result;
        }
    }
