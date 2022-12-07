using System.Diagnostics;
using System.Text;
using System.Text.Json;
using SQLiteDemoWithBlazorApp.Models;
using SQLiteDemoWithBlazorApp.Services;

namespace SQLiteDemoWithBlazorApp.Services
{
    public class RestService : IRestService
    {
        HttpClient _client;
        JsonSerializerOptions _serializerOptions;
        IHttpsClientHandlerService _httpsClientHandlerService;

        public List<TodoItem> Items { get; private set; }
       

        public RestService(IHttpsClientHandlerService service)
        {
#if DEBUG
            _httpsClientHandlerService = service;
            HttpMessageHandler handler = _httpsClientHandlerService.GetPlatformMessageHandler();
            if (handler != null)
                _client = new HttpClient(handler);
            else
                _client = new HttpClient();
#else
            _client = new HttpClient();
#endif
            _serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
        }

        public async Task<List<TodoItem>> RefreshDataAsync()
        {
            Items = new List<TodoItem>();

            Uri uri = new Uri(string.Format(Constants.RestUrl, string.Empty));
            try
            {
                HttpResponseMessage response = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    Items = JsonSerializer.Deserialize<List<TodoItem>>(content, _serializerOptions);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return Items;
        }
        //public List<person> Items_person { get; private set; }
        //public async Task<List<person>> RefreshDataAsync_person()
        //{
        //    string table = "person" , ofc_rolplcid = "950201", pertypid = "1", field = "";
        //    Items_person = new List<person>();
        //    var uriByTable = Constants.RestUrlEditTable +table +"&field=" + field + "&pertypid=" + pertypid + "&ofc_rolplcid=" + ofc_rolplcid;

        //    Uri uri = new Uri(string.Format(uriByTable, string.Empty));
        //    try
        //    {
        //        HttpResponseMessage response = await _client.GetAsync(uri);
        //        if (response.IsSuccessStatusCode)
        //        {
        //            string content = await response.Content.ReadAsStringAsync();
        //            //Items_person = JsonSerializer.Deserialize<List<person>>(content, _serializerOptions);
        //            Items_person = (List<person>)Newtonsoft.Json.JsonConvert.DeserializeObject(content, typeof(List<person>));

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(@"\tERROR {0}", ex.Message);
        //    }

        //    return Items_person;
        //}





        public List<province> Items_province { get; private set; }
        public async Task<List<province>> RefreshDataAsync_province()
        {
            string table = "province";

            Items_province = new List<province>();
            var uriByTable = Constants.RestUrlEditTable + table;

            Uri uri = new Uri(string.Format(uriByTable, string.Empty));
            try
            {
                HttpResponseMessage response = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    //Items_province = JsonSerializer.Deserialize<List<province>>(content, _serializerOptions);
                    Items_province = (List<province>)Newtonsoft.Json.JsonConvert.DeserializeObject(content, typeof(List<province>));

                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return Items_province;
        }

        //public List<district> Items_district { get; private set; }
        //public async Task<List<district>> RefreshDataAsync_district()
        //{
        //    string table = "district";

        //    Items_district = new List<district>();
        //   var uriByTable = Constants.RestUrlEditTable + table;

        //    Uri uri = new Uri(string.Format(uriByTable, string.Empty));
        //    try
        //    {
        //        HttpResponseMessage response = await _client.GetAsync(uri);
        //        if (response.IsSuccessStatusCode)
        //        {
        //            string content = await response.Content.ReadAsStringAsync();
        //            //Items_district = JsonSerializer.Deserialize<List<district>>(content, _serializerOptions);
        //            Items_district = (List<district>)Newtonsoft.Json.JsonConvert.DeserializeObject(content, typeof(List<district>));

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(@"\tERROR {0}", ex.Message);
        //    }

        //    return Items_district;
        //}

        //public List<tambon> Items_tambon { get; private set; }
        //public async Task<List<tambon>> RefreshDataAsync_tambon()
        //{
        //    string table = "tambon";

        //    Items_tambon = new List<tambon>();
        //   var uriByTable = Constants.RestUrlEditTable + table;

        //    Uri uri = new Uri(string.Format(uriByTable, string.Empty));
        //    try
        //    {
        //        HttpResponseMessage response = await _client.GetAsync(uri);
        //        if (response.IsSuccessStatusCode)
        //        {
        //            string content = await response.Content.ReadAsStringAsync();
        //            //Items_tambon = JsonSerializer.Deserialize<List<tambon>>(content, _serializerOptions);
        //            Items_tambon = (List<tambon>)Newtonsoft.Json.JsonConvert.DeserializeObject(content, typeof(List<tambon>));

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(@"\tERROR {0}", ex.Message);
        //    }

        //    return Items_tambon;
        //}
        //public List<const_prenme> Items_const_prenme { get; private set; }
        //public async Task<List<const_prenme>> RefreshDataAsync_const_prenme()
        //{
        //    string table = "const_prenme";

        //    Items_const_prenme = new List<const_prenme>();
        //   var uriByTable = Constants.RestUrlEditTable + table;

        //    Uri uri = new Uri(string.Format(uriByTable, string.Empty));
        //    try
        //    {
        //        HttpResponseMessage response = await _client.GetAsync(uri);
        //        if (response.IsSuccessStatusCode)
        //        {
        //            string content = await response.Content.ReadAsStringAsync();
        //            //Items_const_prenme = JsonSerializer.Deserialize<List<const_prenme>>(content, _serializerOptions);
        //            Items_const_prenme = (List<const_prenme>)Newtonsoft.Json.JsonConvert.DeserializeObject(content, typeof(List<const_prenme>));

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(@"\tERROR {0}", ex.Message);
        //    }

        //    return Items_const_prenme;
        //}

        //public List<const_sex> Items_const_sex { get; private set; }
        //public async Task<List<const_sex>> RefreshDataAsync_const_sex()
        //{
        //    string table = "const_sex";

        //    Items_const_sex = new List<const_sex>();
        //   var uriByTable = Constants.RestUrlEditTable + table;

        //    Uri uri = new Uri(string.Format(uriByTable, string.Empty));
        //    try
        //    {
        //        HttpResponseMessage response = await _client.GetAsync(uri);
        //        if (response.IsSuccessStatusCode)
        //        {
        //            string content = await response.Content.ReadAsStringAsync();
        //            //Items_const_sex = JsonSerializer.Deserialize<List<const_sex>>(content, _serializerOptions);
        //            Items_const_sex = (List<const_sex>)Newtonsoft.Json.JsonConvert.DeserializeObject(content, typeof(List<const_sex>));

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(@"\tERROR {0}", ex.Message);
        //    }

        //    return Items_const_sex;
        //}

        //public List<const_currlev> Items_const_currlev { get; private set; }
        //public async Task<List<const_currlev>> RefreshDataAsync_const_currlev()
        //{
        //    string table = "const_currlev";

        //    Items_const_currlev = new List<const_currlev>();
        //   var uriByTable = Constants.RestUrlEditTable + table;

        //    Uri uri = new Uri(string.Format(uriByTable, string.Empty));
        //    try
        //    {
        //        HttpResponseMessage response = await _client.GetAsync(uri);
        //        if (response.IsSuccessStatusCode)
        //        {
        //            string content = await response.Content.ReadAsStringAsync();
        //            //Items_const_currlev = JsonSerializer.Deserialize<List<const_currlev>>(content, _serializerOptions);
        //            Items_const_currlev = (List<const_currlev>)Newtonsoft.Json.JsonConvert.DeserializeObject(content, typeof(List<const_currlev>));

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(@"\tERROR {0}", ex.Message);
        //    }

        //    return Items_const_currlev;
        //}

        //public List<const_disability_type> Items_const_disability_type { get; private set; }
        //public async Task<List<const_disability_type>> RefreshDataAsync_const_disability_type()
        //{
        //    string table = "const_disability_type";

        //    Items_const_disability_type = new List<const_disability_type>();
        //   var uriByTable = Constants.RestUrlEditTable + table;

        //    Uri uri = new Uri(string.Format(uriByTable, string.Empty));
        //    try
        //    {
        //        HttpResponseMessage response = await _client.GetAsync(uri);
        //        if (response.IsSuccessStatusCode)
        //        {
        //            string content = await response.Content.ReadAsStringAsync();
        //            //Items_const_disability_type = JsonSerializer.Deserialize<List<const_disability_type>>(content, _serializerOptions);
        //            Items_const_disability_type = (List<const_disability_type>)Newtonsoft.Json.JsonConvert.DeserializeObject(content, typeof(List<const_disability_type>));

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(@"\tERROR {0}", ex.Message);
        //    }

        //    return Items_const_disability_type;
        //}

        //public List<const_edulev> Items_const_edulev { get; private set; }
        //public async Task<List<const_edulev>> RefreshDataAsync_const_edulev()
        //{
        //    string table = "const_edulev";

        //    Items_const_edulev = new List<const_edulev>();
        //   var uriByTable = Constants.RestUrlEditTable + table;

        //    Uri uri = new Uri(string.Format(uriByTable, string.Empty));
        //    try
        //    {
        //        HttpResponseMessage response = await _client.GetAsync(uri);
        //        if (response.IsSuccessStatusCode)
        //        {
        //            string content = await response.Content.ReadAsStringAsync();
        //            //Items_const_edulev = JsonSerializer.Deserialize<List<const_edulev>>(content, _serializerOptions);
        //            Items_const_edulev = (List<const_edulev>)Newtonsoft.Json.JsonConvert.DeserializeObject(content, typeof(List<const_edulev>));

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(@"\tERROR {0}", ex.Message);
        //    }

        //    return Items_const_edulev;
        //}

        //public List<const_elderly_grp> Items_const_elderly_grp { get; private set; }
        //public async Task<List<const_elderly_grp>> RefreshDataAsync_const_elderly_grp()
        //{
        //    string table = "const_elderly_grp";

        //    Items_const_elderly_grp = new List<const_elderly_grp>();
        //   var uriByTable = Constants.RestUrlEditTable + table;

        //    Uri uri = new Uri(string.Format(uriByTable, string.Empty));
        //    try
        //    {
        //        HttpResponseMessage response = await _client.GetAsync(uri);
        //        if (response.IsSuccessStatusCode)
        //        {
        //            string content = await response.Content.ReadAsStringAsync();
        //            //Items_const_elderly_grp = JsonSerializer.Deserialize<List<const_elderly_grp>>(content, _serializerOptions);
        //            Items_const_elderly_grp = (List<const_elderly_grp>)Newtonsoft.Json.JsonConvert.DeserializeObject(content, typeof(List<const_elderly_grp>));

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(@"\tERROR {0}", ex.Message);
        //    }

        //    return Items_const_elderly_grp;
        //}

        //public List<const_house_conditions> Items_const_house_conditions { get; private set; }
        //public async Task<List<const_house_conditions>> RefreshDataAsync_const_house_conditions()
        //{
        //    string table = "const_house_conditions";

        //    Items_const_house_conditions = new List<const_house_conditions>();
        //   var uriByTable = Constants.RestUrlEditTable + table;

        //    Uri uri = new Uri(string.Format(uriByTable, string.Empty));
        //    try
        //    {
        //        HttpResponseMessage response = await _client.GetAsync(uri);
        //        if (response.IsSuccessStatusCode)
        //        {
        //            string content = await response.Content.ReadAsStringAsync();
        //            //Items_const_house_conditions = JsonSerializer.Deserialize<List<const_house_conditions>>(content, _serializerOptions);
        //            Items_const_house_conditions = (List<const_house_conditions>)Newtonsoft.Json.JsonConvert.DeserializeObject(content, typeof(List<const_house_conditions>));

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(@"\tERROR {0}", ex.Message);
        //    }

        //    return Items_const_house_conditions;
        //}

        //public List<const_occ> Items_const_occ { get; private set; }
        //public async Task<List<const_occ>> RefreshDataAsync_const_occ()
        //{
        //    string table = "const_occ";

        //    Items_const_occ = new List<const_occ>();
        //   var uriByTable = Constants.RestUrlEditTable + table;

        //    Uri uri = new Uri(string.Format(uriByTable, string.Empty));
        //    try
        //    {
        //        HttpResponseMessage response = await _client.GetAsync(uri);
        //        if (response.IsSuccessStatusCode)
        //        {
        //            string content = await response.Content.ReadAsStringAsync();
        //            //Items_const_occ = JsonSerializer.Deserialize<List<const_occ>>(content, _serializerOptions);
        //            Items_const_occ = (List<const_occ>)Newtonsoft.Json.JsonConvert.DeserializeObject(content, typeof(List<const_occ>));

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(@"\tERROR {0}", ex.Message);
        //    }

        //    return Items_const_occ;
        //}

        //public List<const_pertyp> Items_const_pertyp { get; private set; }
        //public async Task<List<const_pertyp>> RefreshDataAsync_const_pertyp()
        //{
        //    string table = "const_pertyp";

        //    Items_const_pertyp = new List<const_pertyp>();
        //   var uriByTable = Constants.RestUrlEditTable + table;

        //    Uri uri = new Uri(string.Format(uriByTable, string.Empty));
        //    try
        //    {
        //        HttpResponseMessage response = await _client.GetAsync(uri);
        //        if (response.IsSuccessStatusCode)
        //        {
        //            string content = await response.Content.ReadAsStringAsync();
        //            //Items_const_pertyp = JsonSerializer.Deserialize<List<const_pertyp>>(content, _serializerOptions);
        //            Items_const_pertyp = (List<const_pertyp>)Newtonsoft.Json.JsonConvert.DeserializeObject(content, typeof(List<const_pertyp>));

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(@"\tERROR {0}", ex.Message);
        //    }

        //    return Items_const_pertyp;
        //}

        //public List<const_reg> Items_const_reg { get; private set; }
        //public async Task<List<const_reg>> RefreshDataAsync_const_reg()
        //{
        //    string table = "const_reg";

        //    Items_const_reg = new List<const_reg>();
        //   var uriByTable = Constants.RestUrlEditTable + table;

        //    Uri uri = new Uri(string.Format(uriByTable, string.Empty));
        //    try
        //    {
        //        HttpResponseMessage response = await _client.GetAsync(uri);
        //        if (response.IsSuccessStatusCode)
        //        {
        //            string content = await response.Content.ReadAsStringAsync();
        //            //Items_const_reg = JsonSerializer.Deserialize<List<const_reg>>(content, _serializerOptions);
        //            Items_const_reg = (List<const_reg>)Newtonsoft.Json.JsonConvert.DeserializeObject(content, typeof(List<const_reg>));

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(@"\tERROR {0}", ex.Message);
        //    }

        //    return Items_const_reg;
        //}

        //public List<const_reltyp> Items_const_reltyp { get; private set; }
        //public async Task<List<const_reltyp>> RefreshDataAsync_const_reltyp()
        //{
        //    string table = "const_reltyp";

        //    Items_const_reltyp = new List<const_reltyp>();
        //   var uriByTable = Constants.RestUrlEditTable + table;

        //    Uri uri = new Uri(string.Format(uriByTable, string.Empty));
        //    try
        //    {
        //        HttpResponseMessage response = await _client.GetAsync(uri);
        //        if (response.IsSuccessStatusCode)
        //        {
        //            string content = await response.Content.ReadAsStringAsync();
        //            //Items_const_reltyp = JsonSerializer.Deserialize<List<const_reltyp>>(content, _serializerOptions);
        //            Items_const_reltyp = (List<const_reltyp>)Newtonsoft.Json.JsonConvert.DeserializeObject(content, typeof(List<const_reltyp>));

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(@"\tERROR {0}", ex.Message);
        //    }

        //    return Items_const_reltyp;
        //}

        //public List<const_school> Items_const_school { get; private set; }
        //public async Task<List<const_school>> RefreshDataAsync_const_school()
        //{
        //    string table = "const_school";

        //    Items_const_school = new List<const_school>();
        //   var uriByTable = Constants.RestUrlEditTable + table;

        //    Uri uri = new Uri(string.Format(uriByTable, string.Empty));
        //    try
        //    {
        //        HttpResponseMessage response = await _client.GetAsync(uri);
        //        if (response.IsSuccessStatusCode)
        //        {
        //            string content = await response.Content.ReadAsStringAsync();
        //            //Items_const_school = JsonSerializer.Deserialize<List<const_school>>(content, _serializerOptions);
        //            Items_const_school = (List<const_school>)Newtonsoft.Json.JsonConvert.DeserializeObject(content, typeof(List<const_school>));

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(@"\tERROR {0}", ex.Message);
        //    }

        //    return Items_const_school;
        //}

        //public List<const_stsmar> Items_const_stsmar { get; private set; }
        //public async Task<List<const_stsmar>> RefreshDataAsync_const_stsmar()
        //{
        //    string table = "const_stsmar";

        //    Items_const_stsmar = new List<const_stsmar>();
        //   var uriByTable = Constants.RestUrlEditTable + table;

        //    Uri uri = new Uri(string.Format(uriByTable, string.Empty));
        //    try
        //    {
        //        HttpResponseMessage response = await _client.GetAsync(uri);
        //        if (response.IsSuccessStatusCode)
        //        {
        //            string content = await response.Content.ReadAsStringAsync();
        //            //Items_const_stsmar = JsonSerializer.Deserialize<List<const_stsmar>>(content, _serializerOptions);
        //            Items_const_stsmar = (List<const_stsmar>)Newtonsoft.Json.JsonConvert.DeserializeObject(content, typeof(List<const_stsmar>));

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(@"\tERROR {0}", ex.Message);
        //    }

        //    return Items_const_stsmar;
        //}

        //public List<const_vaccination> Items_const_vaccination { get; private set; }
        //public async Task<List<const_vaccination>> RefreshDataAsync_const_vaccination()
        //{
        //    string table = "const_vaccination";

        //    Items_const_vaccination = new List<const_vaccination>();
        //   var uriByTable = Constants.RestUrlEditTable + table;

        //    Uri uri = new Uri(string.Format(uriByTable, string.Empty));
        //    try
        //    {
        //        HttpResponseMessage response = await _client.GetAsync(uri);
        //        if (response.IsSuccessStatusCode)
        //        {
        //            string content = await response.Content.ReadAsStringAsync();
        //            //Items_const_vaccination = JsonSerializer.Deserialize<List<const_vaccination>>(content, _serializerOptions);
        //            Items_const_vaccination = (List<const_vaccination>)Newtonsoft.Json.JsonConvert.DeserializeObject(content, typeof(List<const_vaccination>));

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(@"\tERROR {0}", ex.Message);
        //    }

        //    return Items_const_vaccination;
        //}


        public async Task SaveTodoItemAsync(TodoItem item, bool isNewItem = false)
        {
            Uri uri = new Uri(string.Format(Constants.RestUrl, string.Empty));

            try
            {
                string json = JsonSerializer.Serialize<TodoItem>(item, _serializerOptions);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = null;
                if (isNewItem)
                    response = await _client.PostAsync(uri, content);
                else
                    response = await _client.PutAsync(uri, content);

                if (response.IsSuccessStatusCode)
                    Debug.WriteLine(@"\tTodoItem successfully saved.");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }
        }

        public async Task DeleteTodoItemAsync(string id)
        {
            Uri uri = new Uri(string.Format(Constants.RestUrl, id));

            try
            {
                HttpResponseMessage response = await _client.DeleteAsync(uri);
                if (response.IsSuccessStatusCode)
                    Debug.WriteLine(@"\tTodoItem successfully deleted.");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }
        }
    }
}
