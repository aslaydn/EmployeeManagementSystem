using BaseLibrary.DTOs;
using Blazored.LocalStorage;

namespace ClientLibrary.Helpers
{
    public class LocalStorageService(ILocalStorageService localStorageService)
    {
        private const string StorageKey = "authentication-token";

        //public async Task SetToken(string item) => await localStorageService.SetItemAsync(StorageKey, item);
        public async Task SetToken(UserSession userSession) => await localStorageService.SetItemAsync(StorageKey, userSession);
        public async Task<string> GetToken() => await localStorageService.GetItemAsStringAsync(StorageKey);
        public async Task RemoveToken() => await localStorageService.RemoveItemAsync(StorageKey);
    }
}
