/**
 * Autogenerated by Thrift Compiler (0.11.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Thrift;
using Thrift.Collections;

using Thrift.Protocols;
using Thrift.Protocols.Entities;
using Thrift.Protocols.Utilities;
using Thrift.Transports;
using Thrift.Transports.Client;
using Thrift.Transports.Server;


namespace Jaeger.Thrift
{

  public partial class Span : TBase
  {
    private List<SpanRef> _references;
    private List<Tag> _tags;
    private List<Log> _logs;

    public long TraceIdLow { get; set; }

    public long TraceIdHigh { get; set; }

    public long SpanId { get; set; }

    public long ParentSpanId { get; set; }

    public string OperationName { get; set; }

    public List<SpanRef> References
    {
      get
      {
        return _references;
      }
      set
      {
        __isset.references = true;
        this._references = value;
      }
    }

    public int Flags { get; set; }

    public long StartTime { get; set; }

    public long Duration { get; set; }

    public List<Tag> Tags
    {
      get
      {
        return _tags;
      }
      set
      {
        __isset.tags = true;
        this._tags = value;
      }
    }

    public List<Log> Logs
    {
      get
      {
        return _logs;
      }
      set
      {
        __isset.logs = true;
        this._logs = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool references;
      public bool tags;
      public bool logs;
    }

    public Span()
    {
    }

    public Span(long traceIdLow, long traceIdHigh, long spanId, long parentSpanId, string operationName, int flags, long startTime, long duration) : this()
    {
      this.TraceIdLow = traceIdLow;
      this.TraceIdHigh = traceIdHigh;
      this.SpanId = spanId;
      this.ParentSpanId = parentSpanId;
      this.OperationName = operationName;
      this.Flags = flags;
      this.StartTime = startTime;
      this.Duration = duration;
    }

    public async Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_traceIdLow = false;
        bool isset_traceIdHigh = false;
        bool isset_spanId = false;
        bool isset_parentSpanId = false;
        bool isset_operationName = false;
        bool isset_flags = false;
        bool isset_startTime = false;
        bool isset_duration = false;
        TField field;
        await iprot.ReadStructBeginAsync(cancellationToken);
        while (true)
        {
          field = await iprot.ReadFieldBeginAsync(cancellationToken);
          if (field.Type == TType.Stop)
          {
            break;
          }

          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.I64)
              {
                TraceIdLow = await iprot.ReadI64Async(cancellationToken);
                isset_traceIdLow = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.I64)
              {
                TraceIdHigh = await iprot.ReadI64Async(cancellationToken);
                isset_traceIdHigh = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.I64)
              {
                SpanId = await iprot.ReadI64Async(cancellationToken);
                isset_spanId = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.I64)
              {
                ParentSpanId = await iprot.ReadI64Async(cancellationToken);
                isset_parentSpanId = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 5:
              if (field.Type == TType.String)
              {
                OperationName = await iprot.ReadStringAsync(cancellationToken);
                isset_operationName = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 6:
              if (field.Type == TType.List)
              {
                {
                  References = new List<SpanRef>();
                  TList _list4 = await iprot.ReadListBeginAsync(cancellationToken);
                  for(int _i5 = 0; _i5 < _list4.Count; ++_i5)
                  {
                    SpanRef _elem6;
                    _elem6 = new SpanRef();
                    await _elem6.ReadAsync(iprot, cancellationToken);
                    References.Add(_elem6);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 7:
              if (field.Type == TType.I32)
              {
                Flags = await iprot.ReadI32Async(cancellationToken);
                isset_flags = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 8:
              if (field.Type == TType.I64)
              {
                StartTime = await iprot.ReadI64Async(cancellationToken);
                isset_startTime = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 9:
              if (field.Type == TType.I64)
              {
                Duration = await iprot.ReadI64Async(cancellationToken);
                isset_duration = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 10:
              if (field.Type == TType.List)
              {
                {
                  Tags = new List<Tag>();
                  TList _list7 = await iprot.ReadListBeginAsync(cancellationToken);
                  for(int _i8 = 0; _i8 < _list7.Count; ++_i8)
                  {
                    Tag _elem9;
                    _elem9 = new Tag();
                    await _elem9.ReadAsync(iprot, cancellationToken);
                    Tags.Add(_elem9);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 11:
              if (field.Type == TType.List)
              {
                {
                  Logs = new List<Log>();
                  TList _list10 = await iprot.ReadListBeginAsync(cancellationToken);
                  for(int _i11 = 0; _i11 < _list10.Count; ++_i11)
                  {
                    Log _elem12;
                    _elem12 = new Log();
                    await _elem12.ReadAsync(iprot, cancellationToken);
                    Logs.Add(_elem12);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            default: 
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              break;
          }

          await iprot.ReadFieldEndAsync(cancellationToken);
        }

        await iprot.ReadStructEndAsync(cancellationToken);
        if (!isset_traceIdLow)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_traceIdHigh)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_spanId)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_parentSpanId)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_operationName)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_flags)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_startTime)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_duration)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public async Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
    {
      oprot.IncrementRecursionDepth();
      try
      {
        var struc = new TStruct("Span");
        await oprot.WriteStructBeginAsync(struc, cancellationToken);
        var field = new TField();
        field.Name = "traceIdLow";
        field.Type = TType.I64;
        field.ID = 1;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteI64Async(TraceIdLow, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "traceIdHigh";
        field.Type = TType.I64;
        field.ID = 2;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteI64Async(TraceIdHigh, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "spanId";
        field.Type = TType.I64;
        field.ID = 3;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteI64Async(SpanId, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "parentSpanId";
        field.Type = TType.I64;
        field.ID = 4;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteI64Async(ParentSpanId, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "operationName";
        field.Type = TType.String;
        field.ID = 5;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteStringAsync(OperationName, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        if (References != null && __isset.references)
        {
          field.Name = "references";
          field.Type = TType.List;
          field.ID = 6;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          {
            await oprot.WriteListBeginAsync(new TList(TType.Struct, References.Count), cancellationToken);
            foreach (SpanRef _iter13 in References)
            {
              await _iter13.WriteAsync(oprot, cancellationToken);
            }
            await oprot.WriteListEndAsync(cancellationToken);
          }
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        field.Name = "flags";
        field.Type = TType.I32;
        field.ID = 7;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteI32Async(Flags, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "startTime";
        field.Type = TType.I64;
        field.ID = 8;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteI64Async(StartTime, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "duration";
        field.Type = TType.I64;
        field.ID = 9;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteI64Async(Duration, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        if (Tags != null && __isset.tags)
        {
          field.Name = "tags";
          field.Type = TType.List;
          field.ID = 10;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          {
            await oprot.WriteListBeginAsync(new TList(TType.Struct, Tags.Count), cancellationToken);
            foreach (Tag _iter14 in Tags)
            {
              await _iter14.WriteAsync(oprot, cancellationToken);
            }
            await oprot.WriteListEndAsync(cancellationToken);
          }
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (Logs != null && __isset.logs)
        {
          field.Name = "logs";
          field.Type = TType.List;
          field.ID = 11;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          {
            await oprot.WriteListBeginAsync(new TList(TType.Struct, Logs.Count), cancellationToken);
            foreach (Log _iter15 in Logs)
            {
              await _iter15.WriteAsync(oprot, cancellationToken);
            }
            await oprot.WriteListEndAsync(cancellationToken);
          }
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        await oprot.WriteFieldStopAsync(cancellationToken);
        await oprot.WriteStructEndAsync(cancellationToken);
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override string ToString()
    {
      var sb = new StringBuilder("Span(");
      sb.Append(", TraceIdLow: ");
      sb.Append(TraceIdLow);
      sb.Append(", TraceIdHigh: ");
      sb.Append(TraceIdHigh);
      sb.Append(", SpanId: ");
      sb.Append(SpanId);
      sb.Append(", ParentSpanId: ");
      sb.Append(ParentSpanId);
      sb.Append(", OperationName: ");
      sb.Append(OperationName);
      if (References != null && __isset.references)
      {
        sb.Append(", References: ");
        sb.Append(References);
      }
      sb.Append(", Flags: ");
      sb.Append(Flags);
      sb.Append(", StartTime: ");
      sb.Append(StartTime);
      sb.Append(", Duration: ");
      sb.Append(Duration);
      if (Tags != null && __isset.tags)
      {
        sb.Append(", Tags: ");
        sb.Append(Tags);
      }
      if (Logs != null && __isset.logs)
      {
        sb.Append(", Logs: ");
        sb.Append(Logs);
      }
      sb.Append(")");
      return sb.ToString();
    }
  }

}
