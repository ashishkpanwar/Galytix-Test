using System;
using WebApp.Models;
using WebApp.Models.Response;

namespace WebApp.Api.ServiceInterface
{
	public interface IGwpAvgService
	{
        public List<GwpAvgResponeModel> GetGwpAvg(GwpAvgModel model);

    }
}

