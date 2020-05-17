using EndToEnd.Data.EndToEnd;
using EndToEndDB.Data.EndToEnd;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EndToEnd.Pages
{
    public partial class FetchMemories
    {
        // AuthenticationState is available as a CascadingParameter
        [CascadingParameter]
        private Task<AuthenticationState> authenticationStateTask { get; set; }
        List<Memories> memories;

        protected override async Task OnInitializedAsync()
        {
            // Get the current user
            var user = (await authenticationStateTask).User;
            // Get the forecasts for the current user
            // We access WeatherForecastService using @Service
            memories = await @Service.GetMemoriesAsync(user.Identity.Name);
        }

        Memories objMemories = new Memories();
       MemType objMemType = new MemType();
        bool ShowPopup = false;

        void ClosePopup()
        {
            // Close the Popup
            ShowPopup = false;
        }
        void AddNewMemory()
        {
            // Make new forecast
            objMemories= new Memories();
            // Set Id to 0 so we know it is a new record
            objMemories.Id = 0;
            // Open the Popup
            ShowPopup = true;
        }

        async Task SaveMemory()
        {
            // Close the Popup
            ShowPopup = false;
            // Get the current user
            var user = (await authenticationStateTask).User;
            // A new forecast will have the Id set to 0
            if (objMemories.Id == 0)
            {
                MemType objMemType = new MemType();
                // Create new forecast
                Memories objNewMemories = new Memories();
                objNewMemories.memDate = System.DateTime.Now;
                objNewMemories.memType = TypeOfMemories.ToString();
                objNewMemories.memText =objMemories.memText;
               
                objNewMemories.UserName = user.Identity.Name;
                // Save the result
                var result =
                @Service.CreateMemoriesAsync(objNewMemories);
            }
            else
            {
                // This is an update
                var result =
                @Service.UpdateMemoriesAsync(objMemories);
            }
            // Get the forecasts for the current user
            memories =
            await @Service.GetMemoriesAsync(user.Identity.Name);
        }

        void EditMemories(Memories memories)
        {
            // Set the selected forecast
            // as the current forecast
            objMemories = memories;
            // Open the Popup
            ShowPopup = true;
        }

        async Task DeleteMemories()
        {
            // Close the Popup
            ShowPopup = false;
            // Get the current user
            var user = (await authenticationStateTask).User;
            // Delete the forecast
            var result = @Service.DeleteMemoriesAsync(objMemories);
            // Get the forecasts for the current user
            memories =
            await @Service.GetMemoriesAsync(user.Identity.Name);
        }
    }
}
