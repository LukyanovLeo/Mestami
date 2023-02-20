using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Mestami.Infrastructure.Repositories.Queries
{
    public static class LoungeBarQueries
    {
        public const string GetAll = @"
SELECT id, 
    city_id as CityId, 
    address,
    vip_room_info as VipRoomInfo, 
    approx_price as ApproxPrice, 
    pros, 
    cons,
    title
FROM public.place;";

        public const string GetByFilter = @"
SELECT hp.id, 
    c.name as City,
	hp.title,
    hp.address,
    hp.vip_room_info as VipRoomInfo, 
    hp.approx_price as ApproxPrice, 
    hp.pros, 
    hp.cons
FROM public.place hp
JOIN public.city c on c.id = hp.city_id
WHERE c.name LIKE '%'||@city||'%'
	AND hp.title LIKE '%'||@title||'%'
	AND hp.address LIKE '%'||@address||'%';";
    }
}
