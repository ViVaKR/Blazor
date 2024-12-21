declare global { // 전역 객체에 CodeModel 클래스를 선언하기 위해 global 객체에 선언
    interface Window { // window 객체에 선언
        CodeModel: typeof CodeModel; // CodeModel 클래스를 전역 객체로 사용하기 위해 선클
    }
}

interface ICodeModel {
    id: number;
    title: string;
    content: string;
    createdAt: Date;
}

export class CodeModel implements ICodeModel {
    private _id: number;
    private _title: string;
    private _content: string;
    private _createdAt: Date;

    constructor(id: number, title: string, content: string) {
        this._id = id;
        this._title = title;
        this._content = content;
        this._createdAt = new Date();
    }

    get id(): number {
        return this._id;
    }

    get title(): string {
        return this._title;
    }

    set title(value: string) {
        this._title = value;
    }

    get content(): string {
        return this._content;
    }

    set content(value: string) {
        this._content = value;
    }

    get createdAt(): Date {
        return this._createdAt;
    }

    public toString(): string {
        return `CodeModel: ${this._id} - ${this._title}`;
    }

    public static getCurrentInstance(): CodeModel {
        return (window as any).currentInstance || null;
    }

    public static create(id: number, title: string, content: string): CodeModel {
        const instance = new CodeModel(id, title, content);
        (window as any).currentInstance = instance;
        return instance;
    }
}
