﻿using AutoMapper;

using JqueryDataTables.ServerSide.AspNetCoreWeb.Infrastructure;
using JqueryDataTables.ServerSide.AspNetCoreWeb.Models;

using Microsoft.EntityFrameworkCore;

using SmartH2RCore.Core.Uow;
using SmartH2RCore.Models.Common;
using SmartH2RCore.Models.DTO.Master;
using SmartH2RCore.Services.Base;
using SmartH2RCore.Services.Interface;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartH2RCore.Services.Service
{
    public class DepartmentServices : BaseService<Department>, IDepartmentServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DepartmentServices(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public override Task<Department> AddAsync(Department entity)
        {
            entity.DepartmentType = null;
            return base.AddAsync(entity);
        }

        public override Task UpdateAsync(Department entity)
        {
            entity.DepartmentType = null;
            return base.UpdateAsync(entity);
        }

        public async Task<JqueryDataTablesPagedResults<DepartmentDTO>> GetDepartment(JqueryDataTablesParameters table)
        {
            var query = _unitOfWork.GetRepository<Department>().GetAll().Include(v => v.DepartmentType).Where(v => !v.IsArchived)
                                                   .AsNoTracking();
            query = SearchOptionsProcessor<DepartmentDTO, Department>.Apply(query, table.Columns);
            query = SortOptionsProcessor<DepartmentDTO, Department>.Apply(query, table);

            var size = await query.CountAsync();

            List<Department> items;

            if (table.Length > 0)
            {
                items = await query
                .Skip((table.Start / table.Length) * table.Length)
                .Take(table.Length)
                .ToListAsync();
            }
            else
            {
                items = await query.ToListAsync();
            }

            return new JqueryDataTablesPagedResults<DepartmentDTO>
            {
                Items = _mapper.Map<List<DepartmentDTO>>(items),
                TotalSize = size
            };
        }
    }
}
