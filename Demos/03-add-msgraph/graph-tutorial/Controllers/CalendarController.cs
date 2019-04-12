// Copyright (c) Microsoft. All rights reserved. Licensed under the MIT license. See LICENSE in the project root for license information.
using graph_tutorial.Helpers;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace graph_tutorial.Controllers
{
    public class CalendarController : BaseController
    {
        // GET: Calendar
        [Authorize]
        public async Task<ActionResult> Index2()
        {
            var events = await GraphHelper.GetEventsAsync();
            return View(events);
        }

        [AllowAnonymous]
        // GET: Calendar
        public async Task<ActionResult> Index()
        {
            var userId = "ab7e9b7e-aaeb-4944-84c0-ef65ecf4a8d0";
            var token = "eyJ0eXAiOiJKV1QiLCJub25jZSI6IkFRQUJBQUFBQUFEQ29NcGpKWHJ4VHE5Vkc5dGUtN0ZYQWxjaHg0RldVYUJNRDdBZ0ZvUGdLVHZxZUhxaFlrUlo2QUhaaTBYa0NiVmVMaU1xN3dxRmlCdV9yOVJBLWVLNHVGOWY1R1BiWkVmLVhwdy0yS1FXLWlBQSIsImFsZyI6IlJTMjU2IiwieDV0IjoiTi1sQzBuLTlEQUxxd2h1SFluSFE2M0dlQ1hjIiwia2lkIjoiTi1sQzBuLTlEQUxxd2h1SFluSFE2M0dlQ1hjIn0.eyJhdWQiOiJodHRwczovL2dyYXBoLm1pY3Jvc29mdC5jb20iLCJpc3MiOiJodHRwczovL3N0cy53aW5kb3dzLm5ldC85YmJiY2IwMy00ZGMzLTQ0YTMtYTYzZS0wYjQ5MDk4N2Y0Y2MvIiwiaWF0IjoxNTU1MDc2ODQ5LCJuYmYiOjE1NTUwNzY4NDksImV4cCI6MTU1NTA4MDc0OSwiYWNjdCI6MCwiYWNyIjoiMSIsImFpbyI6IkFTUUEyLzhMQUFBQVFPLzB3K1VOaFU0Q3BDZ0V3bE1mMVZMS2piaTlwLzdxQ2hadDQxRVVuUzA9IiwiYW1yIjpbInB3ZCJdLCJhcHBfZGlzcGxheW5hbWUiOiJBbmd1bGFyIEdyYXBoIFR1dG9yaWFsIiwiYXBwaWQiOiJmYTIwMDJjYS1lYjIyLTQwZjEtYmYzNy1mMDUyZTJlMGYyMDQiLCJhcHBpZGFjciI6IjAiLCJmYW1pbHlfbmFtZSI6IkJhdGlzdGEiLCJnaXZlbl9uYW1lIjoiQWJlbGFyZG8iLCJpcGFkZHIiOiI2NS4yNDQuMTQ4LjIyMiIsIm5hbWUiOiJBYmVsYXJkbyBCYXRpc3RhIiwib2lkIjoiYWI3ZTliN2UtYWFlYi00OTQ0LTg0YzAtZWY2NWVjZjRhOGQwIiwib25wcmVtX3NpZCI6IlMtMS01LTIxLTE4MzIxNDAwNTMtMjI5MjAyNTQzNi00Mzk3MzU4ODctMjM0ODI4IiwicGxhdGYiOiIzIiwicHVpZCI6IjEwMDMzRkZGQUQ0OTMzMzIiLCJzY3AiOiJDYWxlbmRhcnMuUmVhZCBvcGVuaWQgcHJvZmlsZSBVc2VyLlJlYWQgZW1haWwiLCJzaWduaW5fc3RhdGUiOlsiaW5rbm93bm50d2siXSwic3ViIjoiX0NUWmx2aGxFeGNxWC14Q29nV1ctOWgtUDNIclFoMEItSnloVUFMaWVQcyIsInRpZCI6IjliYmJjYjAzLTRkYzMtNDRhMy1hNjNlLTBiNDkwOTg3ZjRjYyIsInVuaXF1ZV9uYW1lIjoiQWJlbGFyZG9fQmF0aXN0YUByeWRlci5jb20iLCJ1cG4iOiJBYmVsYXJkb19CYXRpc3RhQHJ5ZGVyLmNvbSIsInV0aSI6ImVWdXV0TU51eTAtU3BoSm42azgyQVEiLCJ2ZXIiOiIxLjAiLCJ4bXNfc3QiOnsic3ViIjoiMUpfZWpVaW90V3AwZlMzaDlsSGtwdUNHaUhzdVB2RG43Q1ZFY3NuMDhNNCJ9LCJ4bXNfdGNkdCI6MTM0NTc0OTE3OH0.IU3Z24HJNiHBfgpSA8tezW1PHdge2TOBafr3UOccIrjPdtxKUimyFewoKGDizfnwmWYSgLioom0JiRjAATeeQ_EkGuFyNcTrSWQjdqrTFRbRPHWT3PKuNEIEfa2IG7AGTSYbVkz8is07huLQB3NZPYN_k-ca-8Yfa_4zTHCKnFdqeLtfF9YjQ7D6Yq9AEIUA6fDkusKni1LjYAIuCDPk0M9CCs8TdlrBob4VnYn6LFnrydhZIcAmy_Ay2V9nMtaYWTDfLob6AwZs5qR7i29jMAF86F_QlEBGjHN70MFg9_GNi2AnEMP7QqvoNGvbNSsXCisCTEhNa4lE827uL3eZMA";
            var events = await GraphHelper.GetEventsAsyncFromUserIdToken(userId, token);
            return View(events);
        }
    }
}