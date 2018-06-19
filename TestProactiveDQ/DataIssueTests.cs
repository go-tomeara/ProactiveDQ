using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProactiveDQ
{
    [TestClass()]
    public class DataIssueTests : SqlDatabaseTestClass
    {

        public DataIssueTests()
        {
            InitializeComponent();
        }

        [TestInitialize()]
        public void TestInitialize()
        {
            base.InitializeTest();
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            base.CleanupTest();
        }

        #region Designer support code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dq_sp_DataIssue_InsertTest_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataIssueTests));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dq_sp_DataIssue_InsertTest_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dq_sp_DataIssue_InsertTest_PosttestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction StagingLookupTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction StagingLookupTest_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction StagingLookupTest_PosttestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ExecuteSimulatedSSISPackage_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition Staging_ExampleDataRowCount;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition DataVault_ExampleTypeData;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition DataVault_ExampleData;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition dq_DataIssue;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ExecuteSimulatedSSISPackage_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ExecuteSimulatedSSISPackage_PosttestAction;
            this.dq_sp_DataIssue_InsertTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.StagingLookupTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.ExecuteSimulatedSSISPackageData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            dq_sp_DataIssue_InsertTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            dq_sp_DataIssue_InsertTest_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            dq_sp_DataIssue_InsertTest_PosttestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            StagingLookupTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            scalarValueCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            StagingLookupTest_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            StagingLookupTest_PosttestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            ExecuteSimulatedSSISPackage_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Staging_ExampleDataRowCount = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            DataVault_ExampleTypeData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            DataVault_ExampleData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            dq_DataIssue = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            ExecuteSimulatedSSISPackage_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            ExecuteSimulatedSSISPackage_PosttestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            // 
            // dq_sp_DataIssue_InsertTest_TestAction
            // 
            dq_sp_DataIssue_InsertTest_TestAction.Conditions.Add(rowCountCondition1);
            resources.ApplyResources(dq_sp_DataIssue_InsertTest_TestAction, "dq_sp_DataIssue_InsertTest_TestAction");
            // 
            // rowCountCondition1
            // 
            rowCountCondition1.Enabled = true;
            rowCountCondition1.Name = "rowCountCondition1";
            rowCountCondition1.ResultSet = 1;
            rowCountCondition1.RowCount = 1;
            // 
            // dq_sp_DataIssue_InsertTest_PretestAction
            // 
            resources.ApplyResources(dq_sp_DataIssue_InsertTest_PretestAction, "dq_sp_DataIssue_InsertTest_PretestAction");
            // 
            // dq_sp_DataIssue_InsertTest_PosttestAction
            // 
            resources.ApplyResources(dq_sp_DataIssue_InsertTest_PosttestAction, "dq_sp_DataIssue_InsertTest_PosttestAction");
            // 
            // StagingLookupTest_TestAction
            // 
            StagingLookupTest_TestAction.Conditions.Add(scalarValueCondition1);
            resources.ApplyResources(StagingLookupTest_TestAction, "StagingLookupTest_TestAction");
            // 
            // scalarValueCondition1
            // 
            scalarValueCondition1.ColumnNumber = 1;
            scalarValueCondition1.Enabled = true;
            scalarValueCondition1.ExpectedValue = "2";
            scalarValueCondition1.Name = "scalarValueCondition1";
            scalarValueCondition1.NullExpected = false;
            scalarValueCondition1.ResultSet = 1;
            scalarValueCondition1.RowNumber = 1;
            // 
            // StagingLookupTest_PretestAction
            // 
            resources.ApplyResources(StagingLookupTest_PretestAction, "StagingLookupTest_PretestAction");
            // 
            // StagingLookupTest_PosttestAction
            // 
            resources.ApplyResources(StagingLookupTest_PosttestAction, "StagingLookupTest_PosttestAction");
            // 
            // ExecuteSimulatedSSISPackage_TestAction
            // 
            ExecuteSimulatedSSISPackage_TestAction.Conditions.Add(Staging_ExampleDataRowCount);
            ExecuteSimulatedSSISPackage_TestAction.Conditions.Add(DataVault_ExampleTypeData);
            ExecuteSimulatedSSISPackage_TestAction.Conditions.Add(DataVault_ExampleData);
            ExecuteSimulatedSSISPackage_TestAction.Conditions.Add(dq_DataIssue);
            resources.ApplyResources(ExecuteSimulatedSSISPackage_TestAction, "ExecuteSimulatedSSISPackage_TestAction");
            // 
            // Staging_ExampleDataRowCount
            // 
            Staging_ExampleDataRowCount.ColumnNumber = 1;
            Staging_ExampleDataRowCount.Enabled = true;
            Staging_ExampleDataRowCount.ExpectedValue = "4";
            Staging_ExampleDataRowCount.Name = "Staging_ExampleDataRowCount";
            Staging_ExampleDataRowCount.NullExpected = false;
            Staging_ExampleDataRowCount.ResultSet = 1;
            Staging_ExampleDataRowCount.RowNumber = 1;
            // 
            // DataVault_ExampleTypeData
            // 
            DataVault_ExampleTypeData.ColumnNumber = 1;
            DataVault_ExampleTypeData.Enabled = true;
            DataVault_ExampleTypeData.ExpectedValue = "3";
            DataVault_ExampleTypeData.Name = "DataVault_ExampleTypeData";
            DataVault_ExampleTypeData.NullExpected = false;
            DataVault_ExampleTypeData.ResultSet = 2;
            DataVault_ExampleTypeData.RowNumber = 1;
            // 
            // DataVault_ExampleData
            // 
            DataVault_ExampleData.ColumnNumber = 1;
            DataVault_ExampleData.Enabled = true;
            DataVault_ExampleData.ExpectedValue = "3";
            DataVault_ExampleData.Name = "DataVault_ExampleData";
            DataVault_ExampleData.NullExpected = false;
            DataVault_ExampleData.ResultSet = 3;
            DataVault_ExampleData.RowNumber = 1;
            // 
            // dq_DataIssue
            // 
            dq_DataIssue.ColumnNumber = 1;
            dq_DataIssue.Enabled = true;
            dq_DataIssue.ExpectedValue = "3";
            dq_DataIssue.Name = "dq_DataIssue";
            dq_DataIssue.NullExpected = false;
            dq_DataIssue.ResultSet = 4;
            dq_DataIssue.RowNumber = 1;
            // 
            // ExecuteSimulatedSSISPackage_PretestAction
            // 
            resources.ApplyResources(ExecuteSimulatedSSISPackage_PretestAction, "ExecuteSimulatedSSISPackage_PretestAction");
            // 
            // ExecuteSimulatedSSISPackage_PosttestAction
            // 
            resources.ApplyResources(ExecuteSimulatedSSISPackage_PosttestAction, "ExecuteSimulatedSSISPackage_PosttestAction");
            // 
            // dq_sp_DataIssue_InsertTestData
            // 
            this.dq_sp_DataIssue_InsertTestData.PosttestAction = dq_sp_DataIssue_InsertTest_PosttestAction;
            this.dq_sp_DataIssue_InsertTestData.PretestAction = dq_sp_DataIssue_InsertTest_PretestAction;
            this.dq_sp_DataIssue_InsertTestData.TestAction = dq_sp_DataIssue_InsertTest_TestAction;
            // 
            // StagingLookupTestData
            // 
            this.StagingLookupTestData.PosttestAction = StagingLookupTest_PosttestAction;
            this.StagingLookupTestData.PretestAction = StagingLookupTest_PretestAction;
            this.StagingLookupTestData.TestAction = StagingLookupTest_TestAction;
            // 
            // ExecuteSimulatedSSISPackageData
            // 
            this.ExecuteSimulatedSSISPackageData.PosttestAction = ExecuteSimulatedSSISPackage_PosttestAction;
            this.ExecuteSimulatedSSISPackageData.PretestAction = ExecuteSimulatedSSISPackage_PretestAction;
            this.ExecuteSimulatedSSISPackageData.TestAction = ExecuteSimulatedSSISPackage_TestAction;
        }

        #endregion


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        #endregion

        [TestMethod()]
        public void dq_sp_DataIssue_InsertTest()
        {
            SqlDatabaseTestActions testActions = this.dq_sp_DataIssue_InsertTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod()]
        public void StagingLookupTest()
        {
            SqlDatabaseTestActions testActions = this.StagingLookupTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod()]
        public void ExecuteSimulatedSSISPackage()
        {
            SqlDatabaseTestActions testActions = this.ExecuteSimulatedSSISPackageData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }


        private SqlDatabaseTestActions dq_sp_DataIssue_InsertTestData;
        private SqlDatabaseTestActions StagingLookupTestData;
        private SqlDatabaseTestActions ExecuteSimulatedSSISPackageData;
    }
}
