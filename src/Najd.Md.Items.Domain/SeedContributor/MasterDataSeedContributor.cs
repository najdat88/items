//using LevantLabs.BOS.MasterData.Documents;
//using Najd.Md.Items;
//using LevantLabs.BOS.MasterData.Parties;
//using LevantLabs.BOS.MasterData.Roles;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Threading.Tasks;
//using Volo.Abp.Data;
//using Volo.Abp.DependencyInjection;
//using Volo.Abp.Domain.Repositories;
//using Volo.Abp.Guids;
//using Volo.Abp.MultiTenancy;

//namespace LevantLabs.BOS.MasterData
//{
//    public class MasterDataSeedContributor
//        : IDataSeedContributor, ITransientDependency
//    {
//        private readonly IRepository<Catalog, Guid> _catalogRepository;
//        private readonly IRepository<ItemType, Guid> _itemTypeRepository;
//        private readonly IRepository<Item, Guid> _itemRepository;
//        private readonly IRepository<DocumentType, Guid> _documentTypeRepository;
//        private readonly IRepository<RoleType, Guid> _roleTypeRepository;
//        private readonly IRepository<Party, Guid> _partyRepository;
//        private readonly IGuidGenerator _guidGenerator;
//        private readonly ICurrentTenant _currentTenant;
            
//        public MasterDataSeedContributor(
//            IRepository<Catalog, Guid> catalogRepository,
//            IRepository<ItemType, Guid> itemTypeRepository,
//            IRepository<Item, Guid> itemRepository,
//            IRepository<DocumentType, Guid> documentTypeRepository,
//            IRepository<RoleType, Guid> roleTypeRepository,
//            IRepository<Party, Guid> partyRepository,
//        IGuidGenerator guidGenerator,
//            ICurrentTenant currentTenant)
//        {
//            _catalogRepository = catalogRepository;
//            _itemTypeRepository = itemTypeRepository;
//            _itemRepository = itemRepository;
//            _documentTypeRepository = documentTypeRepository;
//            _roleTypeRepository = roleTypeRepository;
//            _partyRepository = partyRepository;
//            _guidGenerator = guidGenerator;
//            _currentTenant = currentTenant;
//        }

//        public async Task SeedAsync(DataSeedContext context)
//        {
//            using (_currentTenant.Change(context?.TenantId))
//            {
//                await CreatePartyAsync();
//                await CreateRoleTypeAsync();
//                await CreateCatalogAsync();
//                await CreateItemTypeAsync();
//                await CreateItemAsync();
//                await CreateDocumentTypeAsync();
//            }
//        }
//        private async Task CreatePartyAsync()
//        {
//            if (await _partyRepository.GetCountAsync() > 0)
//            {
//                return;
//            }

//            string json = ReadResource("LevantLabs.BOS.MasterData.SeedContributor.party.json");
//            List<Party> parties = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Party>>(json);
//            await _partyRepository.InsertManyAsync(parties);
//        }
//        private async Task CreateRoleTypeAsync()
//        {
//            if (await _roleTypeRepository.GetCountAsync() > 0)
//            {
//                return;
//            }

//            string json = ReadResource("LevantLabs.BOS.MasterData.SeedContributor.role_type.json");
//            List<RoleType> roleTypes = Newtonsoft.Json.JsonConvert.DeserializeObject<List<RoleType>>(json);
//            await _roleTypeRepository.InsertManyAsync(roleTypes);
//        }
//        private async Task CreateCatalogAsync()
//        {
//            if (await _catalogRepository.GetCountAsync() > 0)
//            {
//                return;
//            }

//            //string json = File.ReadAllText("\\path");
//            string json = ReadResource("LevantLabs.BOS.MasterData.SeedContributor.catalog.json");
//            List<Catalog> Catalogs = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Catalog>>(json);
//            await _catalogRepository.InsertManyAsync(Catalogs);
//        }
//        private async Task CreateItemTypeAsync()
//        {
//            if (await _itemTypeRepository.GetCountAsync() > 0)
//            {
//                return;
//            }

//            string json = ReadResource("LevantLabs.BOS.MasterData.SeedContributor.item_type.json");
//            List<ItemType> ItemTypes = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ItemType>>(json);
//            await _itemTypeRepository.InsertManyAsync(ItemTypes);
//        }
//        private async Task CreateItemAsync()
//        {
//            if (await _itemRepository.GetCountAsync() > 0)
//            {
//                return;
//            }

//            string json = ReadResource("LevantLabs.BOS.MasterData.SeedContributor.item.json");
//            List<Item> Items = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Item>>(json);
//            await _itemRepository.InsertManyAsync(Items);
//        }
//        private async Task CreateDocumentTypeAsync()
//        {
//            if (await _documentTypeRepository.GetCountAsync() > 0)
//            {
//                return;
//            }

//            string json = ReadResource("LevantLabs.BOS.MasterData.SeedContributor.document_type.json");
//            List<DocumentType> DocumentTypes = Newtonsoft.Json.JsonConvert.DeserializeObject<List<DocumentType>>(json);
//            await _documentTypeRepository.InsertManyAsync(DocumentTypes);
//        }
//        public string ReadResource(string name)
//        {
//            // Determine path
//            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
//            string resourcePath = name;
//            // Format: "{Namespace}.{Folder}.{filename}.{Extension}"
//            /*if (!name.StartsWith(nameof(SignificantDrawerCompiler)))
//            {
//                resourcePath = assembly.GetManifestResourceNames()
//                    .Single(str => str.EndsWith(name));
//            }*/

//            using (Stream stream = assembly.GetManifestResourceStream(resourcePath))
//            using (StreamReader reader = new StreamReader(stream))
//            {
//                return reader.ReadToEnd();
//            }
//        }

//        /*private async Task CreateItemTypeAsync()
//        {
//            if (await _itemTypeRepository.GetCountAsync() > 0)
//            {
//                return;
//            }

//            List<ItemType> ItemTypes = new List<ItemType>();
//            ItemTypes.Add(new ItemType(
//                code: "item",
//                name: "Item",
//                lineOrder: 1));
//            ItemTypes.Add(new ItemType(
//                code: "service",
//                name: "Service",
//                lineOrder: 1));
//            ItemTypes.Add(new ItemType(
//                code: "stock",
//                name: "Stock",
//                lineOrder: 1));
//            await _itemTypeRepository.InsertManyAsync(ItemTypes);
//        }
//        private async Task CreateDocumentTypeAsync()
//        {
//            if (await _documentTypeRepository.GetCountAsync() > 0)
//            {
//                return;
//            }
//            // http://www.sapspot.com/define-document-types-sap-fico-document-types-sap/
//            List<DocumentType> DocumentTypes = new List<DocumentType>();
//            DocumentTypes.Add(new DocumentType(
//                code: "GDOC",
//                name: "General document",
//                lineOrder: 1));
//            DocumentTypes.Add(new DocumentType(
//                code: "",
//                name: "CO posting",
//                lineOrder: 1));
//            DocumentTypes.Add(new DocumentType(
//                code: "CCME",
//                name: "Customer credit memo",
//                lineOrder: 1));
//            DocumentTypes.Add(new DocumentType(
//                code: "CUPA",
//                name: "Customer payment",
//                lineOrder: 1));
//            DocumentTypes.Add(new DocumentType(
//                code: "CI",
//                name: "Customer invoice",
//                lineOrder: 1));
//            DocumentTypes.Add(new DocumentType(
//                code: "DZ",
//                name: "Vendor payment",
//                lineOrder: 1));
//            DocumentTypes.Add(new DocumentType(
//                code: "",
//                name: "Vendor credit memo",
//                lineOrder: 1));
//            DocumentTypes.Add(new DocumentType(
//                code: "",
//                name: "Vendor net invoice and credit memo",
//                lineOrder: 1));
//            DocumentTypes.Add(new DocumentType(
//                code: "",
//                name: "Vendor invoice",
//                lineOrder: 1));
//            DocumentTypes.Add(new DocumentType(
//                code: "",
//                name: "General G/L accounts",
//                lineOrder: 1));
//            DocumentTypes.Add(new DocumentType(
//                code: "",
//                name: "",
//                lineOrder: 1));
//            await _documentTypeRepository.InsertManyAsync(DocumentTypes);
//        }
//        */
//    }
//}