using global::TechTalk.SpecFlow;

public class VierGewinntTest_SpecFlowPlusRunnerAssemblyHooks
{
    [global::TechTalk.SpecRun.AssemblyInitialize]
    public static void AssemblyInitialize()
    {
        TestRunnerManager.GetTestRunner().OnTestRunStart();
    }

    [global::TechTalk.SpecRun.AssemblyCleanup]
    public static void AssemblyCleanup()
    {
        TestRunnerManager.OnTestRunEnd();
    }
}
