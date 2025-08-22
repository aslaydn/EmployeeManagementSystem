using BaseLibrary.Entities;
using BaseLibrary.Responses;
using Microsoft.EntityFrameworkCore;
using ServerLibrary.Data;
using ServerLibrary.Repositories.Contracts;
namespace ServerLibrary.Repositories.Implementations
{
    public class VacationTypeRepository(AppDbContext appDbContext) 
        : IGenericRepositoryInterface<VacationType>
    {
        public async Task<GeneralResponse> DeleteById(int id)
        {
            var item = await appDbContext.VacationTypes.FindAsync(id);
            if (item is null) return NotFound();
            appDbContext.VacationTypes.Remove(item);
            await Commit();
            return Success();
        }

        public async Task<List<VacationType>> GetAll() => await appDbContext
            .VacationTypes
            .AsNoTracking()
            .ToListAsync();

        public async Task<VacationType> GetById(int id) => await appDbContext
            .VacationTypes.FindAsync(id);

        public async Task<GeneralResponse> Insert(VacationType item)
        {
            if (!await CheckName(item.Name!))
                return new GeneralResponse(false, "İzin türü zaten mevcut.");
            appDbContext.VacationTypes.Add(item);
            await Commit();
            return Success();
        }

        public async Task<GeneralResponse> Update(VacationType item)
        {
            var obj = await appDbContext.VacationTypes.FindAsync(item.Id);
            if (obj is null) return NotFound();
            obj.Name= item.Name;
            await Commit();
            return Success();
        }

        private async Task Commit() => await appDbContext.SaveChangesAsync();
        private GeneralResponse NotFound() => new(false, "Kayıt bulunamadı.");
        private GeneralResponse Success() => new(true, "İşlem başarılı.");
        private async Task<bool> CheckName(string name)
        {
            var item = appDbContext.VacationTypes
                .FirstOrDefaultAsync(x => x.Name!.ToLower() == name.ToLower());
            return item is null;
        }
    }
}
