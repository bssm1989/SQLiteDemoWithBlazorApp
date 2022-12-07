using SQLiteDemoWithBlazorApp.Models;

namespace SQLiteDemoWithBlazorApp.Services
{
    public class TodoService : ITodoService
    {
        IRestService _restService;

        public TodoService(IRestService service)
        {
            _restService = service;
        }

        public Task<List<TodoItem>> GetTasksAsync()
        {
            return _restService.RefreshDataAsync();
        }
        //public Task<List<person>> GetTasksAsync_person()
        //{
        //    return _restService.RefreshDataAsync_person();
        //}
        public Task<List<province>> GetTasksAsync_province() { return _restService.RefreshDataAsync_province(); }
        public Task<List<district>> GetTasksAsync_district() { return _restService.RefreshDataAsync_district(); }
        public Task<List<tambon>> GetTasksAsync_tambon() { return _restService.RefreshDataAsync_tambon(); }
        public Task<List<const_prenme>> GetTasksAsync_const_prenme() { return _restService.RefreshDataAsync_const_prenme(); }
        public Task<List<const_sex>> GetTasksAsync_const_sex() { return _restService.RefreshDataAsync_const_sex(); }
        public Task<List<const_currlev>> GetTasksAsync_const_currlev() { return _restService.RefreshDataAsync_const_currlev(); }
        public Task<List<const_disability_type>> GetTasksAsync_const_disability_type() { return _restService.RefreshDataAsync_const_disability_type(); }
        public Task<List<const_edulev>> GetTasksAsync_const_edulev() { return _restService.RefreshDataAsync_const_edulev(); }
        public Task<List<const_elderly_grp>> GetTasksAsync_const_elderly_grp() { return _restService.RefreshDataAsync_const_elderly_grp(); }
        public Task<List<const_house_conditions>> GetTasksAsync_const_house_conditions() { return _restService.RefreshDataAsync_const_house_conditions(); }
        public Task<List<const_occ>> GetTasksAsync_const_occ() { return _restService.RefreshDataAsync_const_occ(); }
        public Task<List<const_pertyp>> GetTasksAsync_const_pertyp() { return _restService.RefreshDataAsync_const_pertyp(); }
        public Task<List<const_reg>> GetTasksAsync_const_reg() { return _restService.RefreshDataAsync_const_reg(); }
        public Task<List<const_reltyp>> GetTasksAsync_const_reltyp() { return _restService.RefreshDataAsync_const_reltyp(); }
        public Task<List<const_school>> GetTasksAsync_const_school() { return _restService.RefreshDataAsync_const_school(); }
        public Task<List<const_stsmar>> GetTasksAsync_const_stsmar() { return _restService.RefreshDataAsync_const_stsmar(); }
        public Task<List<const_vaccination>> GetTasksAsync_const_vaccination() { return _restService.RefreshDataAsync_const_vaccination(); }
        public Task SaveTaskAsync(TodoItem item, bool isNewItem = false)
        {
            return _restService.SaveTodoItemAsync(item, isNewItem);
        }

        public Task DeleteTaskAsync(TodoItem item)
        {
            return _restService.DeleteTodoItemAsync(item.ID);
        }
    }
}
