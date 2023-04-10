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
SELECT p.id, 
    c.name as City, 
    p.address,
    p.vip_room_info as VipRoomInfo, 
    p.approx_price as ApproxPrice, 
    p.pros, 
    p.cons,
    p.title
FROM public.place p
JOIN public.city c ON c.id = p.city_id
WHERE is_test = false;";

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


        public const string AddNewPlace = @"
INSERT INTO public.place 
(address, city_id, hookah_quality, vip_room_info, approx_price, pros, cons, title, is_test, place_type_id)
VALUES (@address, @cityId, @hookahQuality, @vipRoomInfo, @approxPrice, @pros, @cons, @title, @isTest, @placeTypeId);";
    }
}
