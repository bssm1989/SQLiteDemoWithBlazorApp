using SQLiteDemoWithBlazorApp.Models;

namespace SQLiteDemoWithBlazorApp.Services
{
    public interface IRestService
    {
        Task<List<TodoItem>> RefreshDataAsync();
        //Task<List<person>> RefreshDataAsync_person();
        Task<List<province>> RefreshDataAsync_province();
        Task<List<district>> RefreshDataAsync_district();
        Task<List<tambon>> RefreshDataAsync_tambon();
        Task<List<const_prenme>> RefreshDataAsync_const_prenme();
        Task<List<const_sex>> RefreshDataAsync_const_sex();
        Task<List<const_currlev>> RefreshDataAsync_const_currlev();
        Task<List<const_disability_type>> RefreshDataAsync_const_disability_type();
        Task<List<const_edulev>> RefreshDataAsync_const_edulev();
        Task<List<const_elderly_grp>> RefreshDataAsync_const_elderly_grp();
        Task<List<const_house_conditions>> RefreshDataAsync_const_house_conditions();
        Task<List<const_occ>> RefreshDataAsync_const_occ();
        Task<List<const_pertyp>> RefreshDataAsync_const_pertyp();
        Task<List<const_reg>> RefreshDataAsync_const_reg();
        Task<List<const_reltyp>> RefreshDataAsync_const_reltyp();
        Task<List<const_school>> RefreshDataAsync_const_school();
        Task<List<const_stsmar>> RefreshDataAsync_const_stsmar();
        Task<List<const_vaccination>> RefreshDataAsync_const_vaccination();

        Task SaveTodoItemAsync(TodoItem item, bool isNewItem);

        Task DeleteTodoItemAsync(string id);
    }
}
