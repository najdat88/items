using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Domain.Repositories;

namespace Najd.Md.Items
{
    public interface IItemManagerRepository : IRepository<Item, Guid>, IQueryable
    {
        Task<Item> FindByNameAsync(string name);

        Task<List<Item>> GetListAsync(
            int skipCount,
            int maxResultCount,
            string sorting,
            string filter = null
        );
    }
    public class ItemManager : FullAuditedEntity<Guid>
    {
        private readonly IItemManagerRepository _itemRepository;

        public ItemManager(IItemManagerRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public async Task<Item> CreateAsync(
            [NotNull] string name,
            DateTime birthDate,
            [CanBeNull] string shortBio = null)
        {
            Check.NotNullOrWhiteSpace(name, nameof(name));

            var existingAuthor = await _itemRepository.FindByNameAsync(name);
            if (existingAuthor != null)
            {
                throw new Exception(name);
            }

            return new Item();
        }

        public async Task ChangeNameAsync(
            [NotNull] Item author,
            [NotNull] string newName)
        {
            Check.NotNull(author, nameof(author));
            Check.NotNullOrWhiteSpace(newName, nameof(newName));

            var existingAuthor = await _itemRepository.FindByNameAsync(newName);
            if (existingAuthor != null && existingAuthor.Id != author.Id)
            {
                throw new Exception(newName);
            }

            //Item.ChangeName(newName);
        }

    }
}
