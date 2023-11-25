using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Application.AutoMapper
{
    public class AutoMapperConfig
    {
        public static Mapper _mapper;
        public static void CreateConfig()
        {
            if (_mapper == null)
            {
                lock ("99")
                {
                    if (_mapper == null)
                    {
                        var config = new MapperConfiguration(cfg =>
                        {
                            //描述当前程序集
                            cfg.AddMaps(AppDomain.CurrentDomain.GetAssemblies());
                        });
                        //1.
                        _mapper = new Mapper(config);
                        //2. //_mapper=config.CreateMapper();
                    }
                }
            }

        }

        //configProvider.CreateMap<Entity.InOutOrderQZ, Poco.InOutOrder>()
        //        .ForMember(poco => poco.LoadTransportPlace, entity => entity.MapFrom(s => s.LoadTransportPlaceName))
        //        .ForMember(poco => poco.LoadTransportPlaceCode, entity => entity.MapFrom(s => s.LoadTransportPlace));
        //configProvider.CreateMap<Entity.PipeLineSum, Poco.PipeLineSum>()
        //       .ForMember(p => p.CreatedBy, opt => opt.Ignore())
        //       .ForMember(p => p.CrtUserName, opt => opt.Ignore())
        //       .ForMember(p => p.CreatedOn, opt => opt.Ignore())
        //       .ForMember(p => p.ModifiedBy, opt => opt.Ignore())
        //       .ForMember(p => p.MntUserName, opt => opt.Ignore())
        //       .ForMember(p => p.ModifiedOn, opt => opt.Ignore());


        public Mapper GetMapper()
        {
            return _mapper;
        }


       
    }
}
