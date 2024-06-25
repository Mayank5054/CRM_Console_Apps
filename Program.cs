
using System;

using System.Configuration;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Query;
using System.Web.Configuration;
using Microsoft.PowerPlatform.Dataverse.Client;
using Microsoft.Xrm.Sdk;
using System.Collections.Generic;
using System.Linq;
using System.Web.Services.Description;
using System.Collections;
using Microsoft.Xrm.Sdk.Client;
using System.Web.UI;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Crm.Sdk.Messages;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["CrmConnection"].ConnectionString;
                using (ServiceClient serviceClient = new ServiceClient(connectionString))
                {
                    if (serviceClient.IsReady)
                    {
                        Console.WriteLine("Connected to CRM successfully!");


                        //var query = new QueryExpression("account");
                        //ColumnSet cs = new ColumnSet("name", "emailaddress1", "accountid");
                        //query.ColumnSet = cs;
                        //LinkEntity accTooppo = new LinkEntity("account", "opportunity", "accountid", "customerid", JoinOperator.Inner);
                        ////accTooppo.LinkCriteria.AddCondition(new ConditionExpression("statecode", ConditionOperator.Equal, 1));
                        //accTooppo.Columns = new ColumnSet("name");
                        //query.LinkEntities.Add(accTooppo);

                        //var accounts1 = serviceClient.RetrieveMultiple(query);
                        //var uniqueAccounts = accounts1.Entities
                        //           .GroupBy(e => new
                        //           {
                        //               id = e.GetAttributeValue<Guid>("accountid"),
                        //               City = e.GetAttributeValue<string>("name")
                        //           })
                        //           .Select(e => e.First())
                        //           .ToList();

                        //foreach (var account in uniqueAccounts)
                        //{
                        //    Console.WriteLine($" {account["name"]} : {account["accountid"]}");
                        //    //Console.WriteLine($"{account.}")
                        //    //Console.WriteLine($"AccountID : {account["City"].ToString()} : {account}");
                        //    //hs.Add(new )
                        //    //AliasedValue accountRef = account.GetAttributeValue<AliasedValue>("opportunity1.name");
                        //    ////string accountName = accountRef.Name;
                        //    ////string accountEmail = accountRef.GetAttributeValue<string>("emailaddress1");
                        //    //Console.WriteLine($"Account: {account.account_name} : {account.opportunity_namme}");
                        //}



                        // Task 02
                        //cr56c_table01
                        //Guid accountId = new Guid("030f538a-0232-ef11-8e4e-000d3af2bf65"); // Replace with an actual account ID
                        //int optionSetValue = 1;
                        //List<int> multiOptionSetValues = new List<int> { 1, 2 }; // Replace with actual multi-option set values
                        //DateTime dateField = DateTime.Now;
                        //Entity newRecord = new Entity("cr56c_table01");
                        //newRecord["cr56c_firstname"] = "Mayank Sheladiya";
                        //newRecord["cr56c_accountid"] = new EntityReference("account", accountId);
                        //newRecord["cr56c_isactive"] = new OptionSetValue(optionSetValue);

                        //newRecord["cr56c_hobbies"] = new OptionSetValueCollection(
                        //    multiOptionSetValues.ConvertAll(value => new OptionSetValue(value))
                        //);
                        //newRecord["cr56c_birthday"] = dateField;
                        //Guid recordId = serviceClient.Create(newRecord);
                        //// update record 
                        //Entity updateRecord = new Entity("cr56c_table01", recordId);
                        //Guid newGuid = new Guid("92890bdc-0a32-ef11-8e4e-000d3af2bf65");
                        //updateRecord["cr56c_accountid"] = new EntityReference("account",newGuid);
                        //serviceClient.Update(updateRecord);
                        //Console.WriteLine("RecordId = " + recordId);
                        ////retrive record
                        //var Query2 = new QueryExpression("cr56c_table01");
                        //Query2.ColumnSet = new ColumnSet(true);
                        //var accounts1 = serviceClient.RetrieveMultiple(Query2);

                        //foreach(var i in accounts1.Entities)
                        //{
                        //    EntityReference _ER = i.GetAttributeValue<EntityReference>("cr56c_accountid");
                        //    OptionSetValue os = (OptionSetValue)i["cr56c_isactive"];
                        //    OptionSetValueCollection OS1 = (OptionSetValueCollection)i["cr56c_hobbies"];

                        //    Console.WriteLine($"{os.Value}"); 
                        //}


                        //Task03
                        //Entity parent = new Entity("cr56c_parenttable");
                        //parent["cr56c_name"] = "Gujarati Thali";
                        //Guid currencyGuid = new Guid("bd7c0772-1e32-ef11-8e4e-000d3af2bf65");
                        //parent["transactioncurrencyid"] = new EntityReference("transactioncurrency", currencyGuid);
                        //parent["cr56c_price"] = new Money(500);
                        //Guid parentRecordId = serviceClient.Create(parent);

                        //EntityCollection ec = new EntityCollection();
                        //Entity child1 = new Entity("cr56c_childtable");
                        //child1["cr56c_name"] = "Sabji";
                        ////child1["cr56c_parentid"] = new EntityReference("cr56c_parenttable", parentRecordId);
                        //child1["cr56c_price"] = new Money(200);

                        //Entity child2 = new Entity("cr56c_childtable");
                        //child2["cr56c_name"] = "Roti";
                        ////child2["cr56c_parentid"] = new EntityReference("cr56c_parenttable", parentRecordId);
                        //child2["cr56c_price"] = new Money(200);

                        //Entity child3 = new Entity("cr56c_childtable");
                        //child3["cr56c_name"] = "Dal";
                        ////child3["cr56c_parentid"] = new EntityReference("cr56c_parenttable", parentRecordId);
                        //child3["cr56c_price"] = new Money(100);

                        //ec.Entities.Add(child1);
                        //ec.Entities.Add(child2);
                        //ec.Entities.Add(child3);
                        //parent.RelatedEntities.Add(new Relationship("cr56c_childtable_ParentId_cr56c_parenttable"), ec);

                        //Console.WriteLine(serviceClient.Create(parent));

                        //using (OrganizationServiceContext osc = new OrganizationServiceContext(serviceClient))
                        //{
                        //    osc.AddObject(child1);
                        //    osc.AddObject(child2);
                        //    osc.AddObject(child3);
                        //    osc.SaveChanges();
                        //}

                        //Task 04
                        //var requests = new OrganizationRequestCollection();

                        //Entity etn1 = new Entity("cr56c_childtable");
                        //etn1["cr56c_name"] = "DalBati";
                        //Guid guid = new Guid("c4dc89b8-1c32-ef11-8e4e-000d3af2bf65");
                        //etn1["cr56c_parentid"] = new EntityReference("cr56c_parenttable",guid);
                        //etn1["cr56c_price"] = new Money(100);

                        //Entity etn2 = new Entity("cr56c_childtable");
                        //etn2["cr56c_name"] = "DalBati";
                        //Guid guid1 = new Guid("c4dc89b8-1c32-ef11-8e4e-000d3af2bf65");
                        //etn2["cr56c_parentid"] = new EntityReference("cr56c_parenttable", guid1);
                        //etn2["cr56c_price"] = new Money(100);

                        //var req1 = new CreateRequest { Target= etn1 };
                        //var req2 = new CreateRequest { Target =  etn2 };
                        //requests.Add(req1);
                        //requests.Add(req2);

                        //var em = new ExecuteMultipleRequest()
                        //{
                        //    Settings = new ExecuteMultipleSettings() { ReturnResponses = true},
                        //    Requests = requests
                        //};
                        //var executeMultiple = (ExecuteMultipleResponse)serviceClient.Execute(em);
                        //foreach(var responseItem in executeMultiple.Responses)
                        //{
                        //    var newRecordId = responseItem.Response.Results["id"];
                        //    Console.WriteLine($"Created record with ID: {newRecordId}");
                        //}


                        //Task 05

                        //var leadId = new Guid("ed325072-2f32-ef11-8e4e-000d3af2bf65");
                        //var lead = serviceClient.Retrieve("lead", leadId, new ColumnSet(true));


                        //var qualifyRequest = new QualifyLeadRequest
                        //{
                        //    CreateAccount = true, // Create account if not already associated
                        //    CreateContact = true,
                        //    CreateOpportunity = true,// Create contact if not already associated
                        //    LeadId = new EntityReference("lead", lead.Id),
                        //    Status = new OptionSetValue(3),
                        //};
                        //var qualifyResponse = (QualifyLeadResponse)serviceClient.Execute(qualifyRequest);
                        //var createdOpportunityId = qualifyResponse.CreatedEntities[0].Id;

                        //var oppId = new Guid("d70ee896-2f32-ef11-8e4e-000d3af2bf65");
                        //Entity opportunityClose = new Entity("opportunityclose");
                        //opportunityClose["subject"] = "Opportunity Closed as Won";
                        //opportunityClose["opportunityid"] = new EntityReference("opportunity", oppId);
                        //opportunityClose["actualend"] = DateTime.Now;
                        //opportunityClose["actualrevenue"] = new Money(100000); // Adjust the actual revenue if necessary
                        //opportunityClose["description"] = "Opportunity won successfully.";

                        //WinOpportunityRequest winRequest = new WinOpportunityRequest
                        //{
                        //    OpportunityClose = opportunityClose,
                        //    Status = new OptionSetValue(3) // Status code for won
                        //};
                        //// Execute the request
                        //serviceClient.Execute(winRequest);


                        QueryExpression query = new QueryExpression("account")
                        {
                            ColumnSet = new ColumnSet("accountid", "name")
                        };

                        // Retrieve accounts
                        EntityCollection accounts = serviceClient.RetrieveMultiple(query);

                        // Create a dictionary to store account email counts
                        Dictionary<Guid, int> accountEmailCounts = new Dictionary<Guid, int>();

                        foreach (var account in accounts.Entities)
                        {
                            Guid accountId = account.Id;
                            string accountName = account.GetAttributeValue<string>("name");

                            // Define the query expression to count emails related to the account
                            QueryExpression emailQuery = new QueryExpression("email")
                            {
                                ColumnSet = new ColumnSet("activityid"),
                                Criteria = new FilterExpression
                                {
                                    Conditions =
                                {
                                    new ConditionExpression("regardingobjectid", ConditionOperator.Equal, accountId)
                                }
                                }
                            };

                            // Retrieve related emails
                            EntityCollection emails = serviceClient.RetrieveMultiple(emailQuery);

                            // Store the count of related emails
                            accountEmailCounts[accountId] = emails.Entities.Count;

                            Console.WriteLine($"Account ID: {accountId}, Name: {accountName}, Email Count: {emails.Entities.Count}");
                        }
                        }

                    else
                    {
                        Console.WriteLine("Failed to connect to CRM.");
                        Console.WriteLine(serviceClient.LastError);
                    }
                }
              
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine($"Exception: {ex.Message}");
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
    
}
