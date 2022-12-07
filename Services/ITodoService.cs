using SQLiteDemoWithBlazorApp.Models;

namespace SQLiteDemoWithBlazorApp.Services
{
    public interface ITodoService
    {
        Task<List<TodoItem>> GetTasksAsync();
        //Task<List<person>> GetTasksAsync_person();

        //Task<List<const_prenme>> GetTasksAsync_const_prenme();
        Task<List<province>> GetTasksAsync_province();
        //Task<List<district>> GetTasksAsync_district();
        //Task<List<tambon>> GetTasksAsync_tambon();
        //Task<List<const_sex>> GetTasksAsync_const_sex();
        //Task<List<const_currlev>> GetTasksAsync_const_currlev();
        //Task<List<const_disability_type>> GetTasksAsync_const_disability_type();
        //Task<List<const_edulev>> GetTasksAsync_const_edulev();
        //Task<List<const_elderly_grp>> GetTasksAsync_const_elderly_grp();
        //Task<List<const_house_conditions>> GetTasksAsync_const_house_conditions();
        //Task<List<const_occ>> GetTasksAsync_const_occ();
        //Task<List<const_pertyp>> GetTasksAsync_const_pertyp();
        //Task<List<const_reg>> GetTasksAsync_const_reg();
        //Task<List<const_reltyp>> GetTasksAsync_const_reltyp();
        //Task<List<const_school>> GetTasksAsync_const_school();
        //Task<List<const_stsmar>> GetTasksAsync_const_stsmar();
        //Task<List<const_vaccination>> GetTasksAsync_const_vaccination();
        Task SaveTaskAsync(TodoItem item, bool isNewItem);
        Task DeleteTaskAsync(TodoItem item);
        
        
        
    }
}
