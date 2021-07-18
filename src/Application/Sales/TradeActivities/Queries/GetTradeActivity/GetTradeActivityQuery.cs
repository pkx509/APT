using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.Sales;
using GFCA.Shared.Models.Dto;
using GFCA.Shared.Models.Vm;
using MediatR;

namespace GFCA.Application.Sales.TradeActivities.Queries.GetTradeActivity
{
    public class GetTradeActivityQuery
        : TradeActivityDto
        , IMapFrom<TradeActivityDto>
        , IRequest<TradeActivityVm>
    {
        public void Mapping(Profile profile)
        {
            //profile.CreateMap<GetTradeActivityQuery, TradeActivityDto>();
            profile.CreateMap<TradeActivityDto, TradeActivity>();

            //profile.CreateMap<GetTradeActivityQuery, TradeActivity>();

            profile.CreateMap<TradeActivity, TradeActivityDto>()
                /*
                .ForMember(d => d.GLGroupName, conf =>
                {
                    conf.MapAtRuntime();
                    conf.MapFrom(_ => _.GLAccount.GLGroup.GroupName);
                })
                */
                .ConvertUsing<TradeActivityTypeConverter>()
            /*
            .ForMember(d => d.GLGroupName, conf =>
        {
            conf.MapAtRuntime();
            conf.MapFrom(_ => _.GLAccount.GLGroup.GroupName);
        })
        .ForMember(d => d.GLGroupId, conf =>
        {
            conf.MapAtRuntime();
            conf.MapFrom(_ => _.GLAccount.GLGroup.GroupId);
        })
        .ForMember(d => d.AccountId, conf =>
        {
            conf.MapAtRuntime();
            conf.MapFrom(_ => _.GLAccount.AccountId);
        })
        .ForMember(d => d.GLCode, conf =>
        {
            conf.MapAtRuntime();
            conf.MapFrom(_ => _.GLAccount.GLCode);
        })
        .ForMember(d => d.GLName, conf =>
        {
            conf.MapAtRuntime();
            conf.MapFrom(_ => _.GLAccount.GLName);
        })
        */
            //.ForMember(d => d.IsFixedContract, o => o.ConvertUsing(new MarkerTypeConverter(), s => s.FixedContract))
            //.ForMember(d => d.IsDeductable, o => o.ConvertUsing(new MarkerTypeConverter(), s => s.Deductable))

            //.ForMember(d => d.HaveSaleInTHB, o => o.ConvertUsing(new MarkerTypeConverter(), s => s.SaleInTHBCS))
            //.ForMember(d => d.HaveSaleInGrossSale, o => o.ConvertUsing(new MarkerTypeConverter(), s => s.SaleInGrossSale))
            //.ForMember(d => d.HaveSaleInNotSale, o => o.ConvertUsing(new MarkerTypeConverter(), s => s.SaleInNotSale))

            //.ForMember(d => d.HaveSaleOutTHB, o => o.ConvertUsing(new MarkerTypeConverter(), s => s.SaleOutTHBCS))
            //.ForMember(d => d.HaveSaleOutGrossSale, o => o.ConvertUsing(new MarkerTypeConverter(), s => s.FixedContract))
            //.ForMember(d => d.HaveSaleOutNotSale, o => o.ConvertUsing(new MarkerTypeConverter(), s => s.SaleOutNotSale))

            ;

            //profile.CreateMap<TradeActivity, GetTradeActivityQuery>()
                /*
                .ForMember(d => d.GLGroupName, conf => {
                    conf.MapAtRuntime();
                    conf.MapFrom(_ => _.GLAccount.GLGroup.GroupName);
                })
                .ForMember(d => d.GLGroupId, conf => {
                    conf.MapAtRuntime();
                    conf.MapFrom(_ => _.GLAccount.GLGroup.GroupId);
                })
                .ForMember(d => d.AccountId, conf => {
                    conf.MapAtRuntime();
                    conf.MapFrom(_ => _.GLAccount.AccountId);
                })
                .ForMember(d => d.GLCode, conf => {
                    conf.MapAtRuntime();
                    conf.MapFrom(_ => _.GLAccount.GLCode);
                })
                .ForMember(d => d.GLName, conf => {
                    conf.MapAtRuntime();
                    conf.MapFrom(_ => _.GLAccount.GLName);
                })
                */

                //.ForMember(d => d.IsFixedContract, o => o.ConvertUsing(new MarkerTypeConverter(), s => s.FixedContract))
                //.ForMember(d => d.IsDeductable, o => o.ConvertUsing(new MarkerTypeConverter(), s => s.Deductable))

                //.ForMember(d => d.HaveSaleInTHB, o => o.ConvertUsing(new MarkerTypeConverter(), s => s.SaleInTHBCS))
                //.ForMember(d => d.HaveSaleInGrossSale, o => o.ConvertUsing(new MarkerTypeConverter(), s => s.SaleInGrossSale))
                //.ForMember(d => d.HaveSaleInNotSale, o => o.ConvertUsing(new MarkerTypeConverter(), s => s.SaleInNotSale))

                //.ForMember(d => d.HaveSaleOutTHB, o => o.ConvertUsing(new MarkerTypeConverter(), s => s.SaleOutTHBCS))
                //.ForMember(d => d.HaveSaleOutGrossSale, o => o.ConvertUsing(new MarkerTypeConverter(), s => s.FixedContract))
                //.ForMember(d => d.HaveSaleOutNotSale, o => o.ConvertUsing(new MarkerTypeConverter(), s => s.SaleOutNotSale))

                //.ForMember(d => d.AbsAmt, o => o.ConvertUsing(new MarkerFormatter(), s => s.NotRelateSaleAbsAmt))
                //;
        }

    }

    public static class MarkerExtension
    {
        public static bool ConvertToBool(this string source)
        {
            bool isMarked = source.ToLower().Equals("X") && !string.IsNullOrEmpty(source);

            return isMarked;
        }
        public static string ConvertToString(this bool source)
        {
            string isMarked = source? "X": string.Empty;

            return isMarked;
        }
    }

    public class MarkerTypeConverter : ITypeConverter<string, bool>
    {

        public bool Convert(string source, bool destination, ResolutionContext context)
        {
            bool isMarked = source.ToLower().Equals("X") && !string.IsNullOrEmpty(source);

            return isMarked;

        }
    }

    public class TradeActivityTypeConverter : ITypeConverter<TradeActivity, TradeActivityDto>
    {
        public TradeActivityDto Convert(TradeActivity source, TradeActivityDto destination, ResolutionContext context)
        {

            TradeActivityDto result = new TradeActivityDto();

            result.TradeActivityId = source.TradeActivityId;
            result.ActivityType = source.ActivityType;
            result.ActivityCode = source.ActivityCode;
            result.ActivityName = source.ActivityName;
            
            result.GLGroupId = source.GLAccount.GLGroupId;
            result.GLGroupName = source.GLAccount.GLGroup.GroupName;
            
            result.AccountId = source.AccountId;
            result.GLCode = source.GLAccount.GLCode;
            result.GLName = source.GLAccount.GLName;
            result.Purpose = source.GLAccount.Purpose;
            
            result.Value = source.Valuable;
            result.Remark = source.Remark;
            
            result.IsFixedContract = source.FixedContract.ConvertToBool();
            result.IsDeductable = source.Deductable.ConvertToBool();
            result.HaveSaleInTHB = source.SaleInTHBCS.ConvertToBool();
            result.HaveSaleInGrossSale = source.SaleInGrossSale.ConvertToBool();
            result.HaveSaleInNotSale = source.SaleInNotSale.ConvertToBool();
            
            result.HaveSaleOutTHB = source.SaleOutTHBCS.ConvertToBool();
            result.HaveSaleOutGrossSale = source.SaleOutGrossSale.ConvertToBool();
            result.HaveSaleOutNotSale = source.SaleOutNotSale.ConvertToBool();
            
            result.AbsAmt = source.NotRelateSaleAbsAmt.ConvertToBool();

            return result;
        }
    }

    public class MarkerConverter : ITypeConverter<string, bool>
    {
        public bool Convert(string source, bool destination, ResolutionContext context)
        {
            if (!string.IsNullOrEmpty(source) && source.Equals("X"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

}
