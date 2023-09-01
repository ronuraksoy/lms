﻿using AutoMapper;
using Lms.Application.Interfaces.Repositories;
using Lms.Comman.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lms.Application.Features.Order.Queries.GetOrderPagedList
{
    public class GetOrderPagedListQueryHandle: IRequestHandler<GetOrderPagedListQueryRequest, IPagedDataResult<GetOrderPagedListQueryResponse>>
    {
        readonly IOrderRepository _orderRepository;
        IMapper _mapper;

        public GetOrderPagedListQueryHandle(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public Task<IPagedDataResult<GetOrderPagedListQueryResponse>> Handle(GetOrderPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
