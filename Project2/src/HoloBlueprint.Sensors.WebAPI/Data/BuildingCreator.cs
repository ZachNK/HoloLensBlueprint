namespace HoloBlueprint.Sensors.WebAPI.Data
{
    using HoloBlueprint.Data;
    using Microsoft.Azure.Documents.Client;
    using System;
    using System.Linq;

    /// <summary>
    /// Building Creator Class
    /// </summary>
    public class BuildingCreator
    {
        private const string EndpointUri = "https://holoprintprint.documents.azure.com:443/";
        private const string PrimaryKey = "fCfttXhufrGE7lPB3B3e9EgIVcaWiumJuSWvrpdKgJZeLXb21YPlZp43TJXY0ik92uM2cQszvcq58H8kBcPo5A==";
        private DocumentClient client;
        private const string DatabaseName = "buildings";
        private const string CollectionName = "BuildingCollection";

        /// <summary>
        /// Loads the building.
        /// </summary>
        /// <param name="buildingNumber">The building number.</param>
        /// <returns>Retuns Building object.</returns>
        public Building LoadBuilding(string buildingNumber)
        {
            this.client = new DocumentClient(new Uri(EndpointUri), PrimaryKey);

            // Set some common query options
            FeedOptions queryOptions = new FeedOptions { MaxItemCount = -1 };

            // Here we find the Andersen family via its LastName
            IQueryable<Building> buildingQuery = this.client.CreateDocumentQuery<Building>(
                    UriFactory.CreateDocumentCollectionUri(DatabaseName, CollectionName), queryOptions)
                    .Where(f => f.Id == buildingNumber);

            // The query is executed synchronously here, but can also be executed asynchronously via the IDocumentQuery<T> interface
            foreach (Building building in buildingQuery)
            {
                return building;
            }

            return null;
        }
    }
}